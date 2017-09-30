using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

	public GameObject explosionAnimation;
	int score = 0;
	public Text scoreText;
	public Text gameOver;
	float timeUpdated = 0;
	/*int health = 3;

	public GameObject[] healthObjects;
	public GameObject heart;*/

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		// every 10th of second get point
		if (Time.time - timeUpdated > 0.1)
			UpdateScore ();
	}

	void UpdateScore()
	{
		++score;
		scoreText.text = "Score: " + score.ToString ();
		timeUpdated = Time.time;
	}

	public void Hit() 
	{
		// gameover
		gameOver.gameObject.SetActive (true);
		Instantiate (explosionAnimation, this.transform.position, Quaternion.identity);
		Destroy (this.gameObject);
	}
}
