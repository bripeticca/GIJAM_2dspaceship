using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

	public GameObject enemy;

	float spawnTime = 1;
	float timeSpawned = 0;

	public GameObject spawnPosn;
	// +/- 10 on X

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.time - timeSpawned > spawnTime) 
		{
			Spawn ();
		}
	}

	void Spawn()
	{
		Vector3 position = spawnPosn.transform.position;
		Debug.Log ("position of spawn " + position);
		Quaternion rotn = new Quaternion ();
		rotn.eulerAngles = new Vector3 (0, 0, -90);
		float randX = Random.Range (-10f, 10f);
		position.x = randX;
		position.z = 0;
		Instantiate (enemy, position, rotn);
		timeSpawned = Time.time;
		spawnTime = Random.Range (0.1f, 0.7f);
	}
}
