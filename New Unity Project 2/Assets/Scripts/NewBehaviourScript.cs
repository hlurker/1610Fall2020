using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipObjectBehavior : MonoBehaviour
{
    public float rotateValue;
    
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
            rotateValue = 180;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rotateValue = 180;
        }

        transform.rotation = Quaternion.Euler(x: 0, y: rotateValue, z: 0);
    }
}
