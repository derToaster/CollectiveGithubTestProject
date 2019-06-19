using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AshkansSphere : MonoBehaviour
{
    public float moveForce = 10f;


    private Rigidbody myBody;
    private Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;

    // Start is called before the first frame update


    private void Awake()
    {
        myBody = GetComponent<Rigidbody>();
        jump = new Vector3(0, 2f, 0);
    }


    private void OnCollisionStay(Collision other)
    {
        isGrounded = true;
    }


    void moveAshkansSphere()
    {    
        //ButtonMapping for Directional Buttons
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        myBody.AddForce(new Vector3(h * moveForce, 0f, v * moveForce));
    }

    void Update()
    {
        //Condition For GameStop
        if (transform.position.y < -2)
        {
            Time.timeScale = 0f;
        }

        //Jumping Mechanic with Space
        moveAshkansSphere();
        if ((Input.GetKeyDown(KeyCode.Space)) && isGrounded)
        {
            myBody.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}

