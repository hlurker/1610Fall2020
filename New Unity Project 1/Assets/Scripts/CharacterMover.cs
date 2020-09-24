using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public float movespeed = 5f, gravity = -9.81f,jumpForce = 10f;

    private Vector3 moveDirection;
    private float yDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var moveSpeedInput = movespeed * Input.GetAxis("Horizontal");

        moveDirection.Set(moveSpeedInput, yDirection, 0);

        yDirection += gravity * Time.deltaTime;

        if (controller.isGrounded)
        {
            yDirection = -1f; 
        }

        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }
        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);
    }
}
