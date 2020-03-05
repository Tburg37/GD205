using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdpersoncamera : MonoBehaviour
   
{
    float yaw;
    float pitch;
    public float mouseSensitivity = 10;
    public Transform target;
    public float dstFromTarget = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        Vector3 targetRotation = new Vector3(pitch, yaw);
        transform.eulerAngles = targetRotation;
        transform.position = target.position - transform.forward * dstFromTarget;
        
    }
}
