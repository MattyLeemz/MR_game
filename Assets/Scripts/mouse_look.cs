using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_look : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    //shooting declarations
    public GameObject gun;
    public GameObject bullet;

    public float fireRate;
    float bufferTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        bufferTime += Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            if (bufferTime > fireRate)
            {
                GameObject shot = Instantiate(bullet);
                shot.transform.position = gun.transform.position;
                shot.transform.forward = this.transform.forward;
                shot.transform.Translate(Vector3.forward * 20 * Time.deltaTime);
                bufferTime = 0f;
            }        
        }
    }
}
