using UnityEngine;
using System.Collections;

public class VectorMovement : MonoBehaviour {

    // controls the ground speed and jumpHeight
    public int speed = 10;
    public int jump = 15;

    //public Transform groundCheck;
    //public float groundCheckRadius;
    //public LayerMask WhatisGround;
    //public bool grounded;

    private Rigidbody myRigidBody;

	void Start () {
        myRigidBody = GetComponent<Rigidbody>();
	}
    
    void FixedUpdate()
    {
        //grounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, WhatisGround);
    }

    // runs this set of code every computer tick
    void Update() {

        //directional movement
        if (Input.GetKey(KeyCode.RightArrow))
        {   
            myRigidBody.velocity = new Vector3(speed, myRigidBody.velocity.y, myRigidBody.velocity.z);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidBody.velocity = new Vector3(-speed, myRigidBody.velocity.y, myRigidBody.velocity.z);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, myRigidBody.velocity.y, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, myRigidBody.velocity.y, -speed);
        }

        //jumping
        //if (Input.GetKeyDown(KeyCode.Space) && grounded)
        //{
           // myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, jump, myRigidBody.velocity.z);
        //}

    }
}
