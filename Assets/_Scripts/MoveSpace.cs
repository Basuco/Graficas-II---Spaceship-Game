using UnityEngine;
using System.Collections;

public class MoveSpace : MonoBehaviour
{
	public Rigidbody rb;
	public bool indW;
	public bool indA;
	public bool indD;
	public float speed;
	public float tilt;
	
	public float RotationSpeed;
	public float AmbientSpeed;

	public GameObject Shot;
	public Transform ShotSpam;
	public float fireRate;

	private float nextFire;
	
	// Use this for initialization
	void Start ()
	{
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton ("Jump") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			//GameObject clone = 
			Instantiate (Shot, ShotSpam.position, ShotSpam.rotation);// as GameObject;
		}
//		if (Input.GetKeyDown ("w")) {
//			indW = true;
//		}
		
//		if (Input.GetKeyUp ("w")) {
//			indW = false;
//		}

//		if (Input.GetKeyDown ("a")) {
//			indA = true;
//		}

//		if (Input.GetKeyUp ("a")) {
//			indA = false;
//		}

//		if (Input.GetKeyDown ("d")) {
//			indD = true;
//		}
		
//		if (Input.GetKeyUp ("d")) {
//			indD = false;
//		}

	}
	
	void FixedUpdate ()
	{
//		if (indW) {
//			rb.AddForce (-1.0f * speed, 0.0f, 0.0f);
//			rb.velocity = new Vector3 (-1.0f, 0.0f, 0.0f);
//		} else {
			//rb.AddForce (transform.right * -10);
//			rb.velocity = Vector3.zero;
//		}

//		if (indA) {
//			rb.AddForce (0.0f, 0.0f, -1.0f * speed);
//			rb.velocity = new Vector3 (0.0f, 0.0f, -1.0f);
			//rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.y * -tilt);
//		} else {
			//rb.AddForce (transform.forward * 10);
//			rb.velocity = Vector3.zero;
//		}

//		if (indD) {
//			rb.AddForce (0.0f, 0.0f, 1.0f * speed);
//			rb.velocity = new Vector3 (0.0f, 0.0f, 1.0f);
//			//rb.rotation = Quaternion.Euler (0.0f, 0.0f, rb.velocity.y * -tilt);
//		} else {
			//rb.AddForce (transform.forward * -10);
//			rb.velocity = Vector3.zero;
//		}

		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (-v, 0.0f, h);

		Vector3 mouseMovement = (Input.mousePosition - (new Vector3(Screen.width, Screen.height, 0) / 2.0f));
		//rb.AddTorque (mouseMovement * RotationSpeed);
		//transform.Rotate(new Vector3(0.0f, mouseMovement.x, -mouseMovement.y) * 0.0045f);


		rb.rotation = Quaternion.Euler (movement.z * speed * tilt, mouseMovement.x, -mouseMovement.y);
		//rb.velocity = movement * speed;
		transform.Translate ((movement*speed)*0.0245f);

		//float roll = Input.GetAxis("Mouse X");
		//float pitch = Input.GetAxis("Mouse Y");
		//rb.AddTorque (0.0f, -roll * RotationSpeed, -pitch * RotationSpeed);

		//Vector3 mouseMovement = (Input.mousePosition - (new Vector3(Screen.width, Screen.height, 0) / 2.0f));
		//rb.AddTorque (mouseMovement * RotationSpeed);
		//transform.Rotate(new Vector3(0.0f, mouseMovement.x, -mouseMovement.y) * 0.0045f);
		//transform.Translate(rb.velocity);
	}
	
}
