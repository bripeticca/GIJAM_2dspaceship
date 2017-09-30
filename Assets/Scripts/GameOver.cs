using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {


	// Use this for initialization
	void Start () {
		GameObject.Find ("Spawn Region").gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) 
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
