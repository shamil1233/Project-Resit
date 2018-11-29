using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBoxSpawn : MonoBehaviour {

public GameObject bigBox;
	
	// Update is called once per frame
	public float spawnRate;
	float nextSpawn;

	int spawnPrefabs;
	float randX;
	Vector2 spawnPosition;
	void Update () 
	{
		if (Time.time > nextSpawn)
		{
			
			Debug.Log(spawnPrefabs);
			switch (spawnPrefabs)
			{
			case 1: 
				Instantiate (bigBox, transform.position, Quaternion.identity);
				break;
			}
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range(-8f, 8f);
			spawnPosition = new Vector2 (randX, transform.position.y);
			Instantiate(bigBox, spawnPosition, Quaternion.identity);
			

		}
	}
}
