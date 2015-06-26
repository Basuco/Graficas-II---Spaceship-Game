using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

//	public GameObject hazard;
//	public Vector3 spawnValues;

	public GUIText restartText;
	public GUIText gameOverText;

	private bool gameOver;
	private bool restart;


	// Use this for initialization
	void Start () {
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		//SpamWaves ();
	}
	
	// Update is called once per frame
	void Update () {
		if (restart) {
			if(Input.GetKeyDown(KeyCode.R)){
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}

	void FixedUpdate(){
		if (gameOver) {
			restartText.text = "Press 'R' to Restart";
			restart = true;
		}
	}

//	void SpamWaves(){
//		Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x,spawnValues.x),spawnValues.y, spawnValues.z);
//		Quaternion spawnRotation = Quaternion.identity;
//		Instantiate (hazard, spawnPosition,spawnRotation);
//	}
	
	public void GameOver(){
		gameOverText.text = "Game Over";
		gameOver = true;
	}
}
