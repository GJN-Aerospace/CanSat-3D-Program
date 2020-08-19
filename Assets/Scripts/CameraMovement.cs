using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float x;
    private float y;
    private Vector3 rotateValue;

    void Update()
     {
        y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y");
        rotateValue = new Vector3(x * 10, y * -10, 0);
        transform.eulerAngles = transform.eulerAngles - rotateValue;
    }
}
