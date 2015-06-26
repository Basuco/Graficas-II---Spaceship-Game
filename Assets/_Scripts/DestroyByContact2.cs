using UnityEngine;
using System.Collections;

public class DestroyByContact2 : MonoBehaviour {
	
	public GameObject explosion;
	public GameObject playerExplosion;
	
	void OnTriggerEnter(Collider other){
		if (other.tag == "Boundary"){
			return;
		} else if (other.tag == "Nave1") {
		Instantiate (explosion, transform.position, transform.rotation);
		Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
		Destroy (other.gameObject);
		Destroy (gameObject);
		} else {
			return;
		}
	}
}