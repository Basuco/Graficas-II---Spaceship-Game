using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public Rigidbody rb;
	public float speed;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		rb.velocity = transform.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
