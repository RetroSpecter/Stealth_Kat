using UnityEngine;
using System.Collections;

public class VectorMovement : MonoBehaviour {

    // controls the ground speed and jumpHeight
    public int speed = 10;
    public int jump = 15;

    public Animator anim;

    //public Transform groundCheck;
    //public float groundCheckRadius;
    //public LayerMask WhatisGround;
    //public bool grounded;

    private Rigidbody myRigidBody;

	void Start () {
        myRigidBody = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
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

        //if(Mathf.Abs(myRigidBody.velocity.x) > 0.1 || Mathf.Abs(myRigidBody.velocity.z) > 0.1)
        //transform.forward = -myRigidBody.velocity;

        //jumping
        //if (Input.GetKeyDown(KeyCode.Space) && grounded)
        //{
        // myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, jump, myRigidBody.velocity.z);
        //}
        if (anim != null) {
            //anim.SetFloat("Blend",myRigidBody.velocity.magnitude);
        }
    }
}
