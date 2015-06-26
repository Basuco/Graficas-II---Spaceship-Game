using UnityEngine;
using System.Collections;

public class TurrentFollow : MonoBehaviour {
	public Rigidbody rb;

	public GameObject shot;
	public Transform target;
	public Transform ShotSpam;
	public float damp = 1.0f;

	public float fireRate;
	private float nextFire;
	private float timer = 0.0f;


	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//rb.transform.LookAt (target);
	}

	void OnTriggerStay(Collider other) {
		timer += Time.deltaTime;
		if (other.tag == "Nave1") {
			Quaternion rotate = Quaternion.LookRotation (target.position - rb.transform.position);
			rb.transform.rotation = Quaternion.Slerp (rb.transform.rotation, rotate, Time.deltaTime * damp);
			nextFire = Time.time + fireRate;

			if (timer > 3.0f){
				Instantiate (shot, ShotSpam.position, ShotSpam.rotation);
				timer = 0.0f;
			}
		}
	}
}
