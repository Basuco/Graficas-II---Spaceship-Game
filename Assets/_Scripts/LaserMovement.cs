using UnityEngine;
using System.Collections;

public class LaserMovement : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	public float yMax;
	public float yMin;
	private bool forceDirection = true;
	
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		forceDirection = true;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (rb.position.y);
		if (rb.position.y > yMax) {
			forceDirection = false;
		}
		if (rb.position.y < yMin) {
			forceDirection = true;
		}
		//if (rb.position.y > yMax || rb.position.y < yMin) {
		//	forceDirection = -forceDirection;
		//}
	}

	void FixedUpdate(){
		if (forceDirection) {
			rb.velocity = transform.right * speed;
		} else {
			rb.velocity = -transform.right * speed;
		}
	}
}
