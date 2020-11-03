using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotateSpeed = 15f;
    public bool canRotate;


    void Update()
    {
        if (canRotate)
        {
            var finalSpeed = rotateSpeed * Time.deltaTime;
            transform.Rotate(xAngle; 0, yAngle: 0, zAngle finalSpeed);
        }
    }
}
