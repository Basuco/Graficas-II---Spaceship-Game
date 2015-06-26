using UnityEngine;
using System.Collections;

public class DestroyLaser : MonoBehaviour {

	public GameObject explosion;
	
	void OnTriggerEnter(Collider other){
		if (other.tag == "Nave1"){
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy(other.gameObject);
		}
	}
}
