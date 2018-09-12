﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ballController : MonoBehaviour {
    Rigidbody rb;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        float hInput = CrossPlatformInputManager.GetAxis("Horizontal") * speed;
        float vInput = CrossPlatformInputManager.GetAxis("Vertical") * speed;

        rb.AddForce(hInput, 0, vInput);
    }
}
