using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingEnemy : MonoBehaviour {


	public float speed = 7;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.down * Time.deltaTime * speed;
	}

	void OnCollisionEnter2D(Collision2D coll)
	{ 
		Debug.Log ("collided");
		if (coll.gameObject.tag == "Player")
		{
			coll.gameObject.GetComponent<PlayerStats>().Hit ();
			SendMessage ("destroyEnemy");
		}
	}

	void destroyEnemy()
	{
		Destroy (this.gameObject);
	}
}
