﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour {

	public GameObject enemyToSpawn;

	public bool canSpawn = true;
	public float enemySpawnTime = 5f;
	public float maxY = 8.0f;
	public float startingX = 25.0f;

	float randomY = 0.0f;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (spawnEnemyTimer());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator spawnEnemyTimer()
	{
		while (canSpawn == true) 
		{
			spawnEnemy ();
			yield return new WaitForSeconds (enemySpawnTime);
		}

	}

	void spawnEnemy()
	{
		randomY = Random.Range (-maxY, maxY);

		Instantiate(enemyToSpawn, new Vector3(startingX, randomY,0),Quaternion.identity);
	}

}
