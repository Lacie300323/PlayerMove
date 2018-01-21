using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float speed = 5.0f;
    public float lerp = 0.5f;
    public float rotation = 25.0f;

    private Rigidbody controller;
    
    // Use this for initialization
	void Start () {
        controller = GetComponent<Rigidbody>();
        controller.maxAngularVelocity = rotation;
        controller.drag = lerp;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        if (direction.magnitude > 1)
            direction.Normalize();
            controller.AddForce(direction * speed);         
	}
}
