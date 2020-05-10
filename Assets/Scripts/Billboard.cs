using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform camera;

    private void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;    
    }

    void LateUpdate()
    {
        transform.LookAt(transform.position + camera.forward);
    }
}
