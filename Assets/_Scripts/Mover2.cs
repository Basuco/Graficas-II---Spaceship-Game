﻿using UnityEngine;
using System.Collections;

public class Mover2 : MonoBehaviour {
	
	public Rigidbody rb;
	public float speed;
	
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
