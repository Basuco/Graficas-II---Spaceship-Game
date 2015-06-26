using UnityEngine;
using System.Collections;

public class CoinRotator : MonoBehaviour {
	public float tumble;
	public Rigidbody rb;
	
	void Start(){
		rb = this.GetComponent<Rigidbody> ();
		rb.angularVelocity = transform.up * tumble;
	}
}
