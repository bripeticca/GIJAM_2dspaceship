using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5;

	// Use this for initialization
	void Start () {
		// begin at desired starting position
		this.transform.position = new Vector3 (0f, -3.6f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.position += Vector3.left * Time.deltaTime * speed;
		} 

		else if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.position += Vector3.right * Time.deltaTime * speed;
		}
	}
}
