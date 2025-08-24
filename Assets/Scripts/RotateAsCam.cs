using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAsCam : MonoBehaviour
{
    public Transform cameraY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.rotation.x, cameraY.rotation.y * 100, transform.rotation.z);
        Vector3 rotation = transform.eulerAngles;
    }
}
