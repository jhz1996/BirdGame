﻿using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    GameObject prefab;
    // Use this for initialization
    void Start () {



        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }
	
	// Update is called once per frame
	void Update () {

      



    }
}
