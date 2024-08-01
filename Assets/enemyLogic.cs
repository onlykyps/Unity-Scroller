using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLogic : MonoBehaviour {

	public float enemySpeed = 1.2f; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveEnemyLeft ();
	}


	void moveEnemyLeft()
	{
		transform.Translate (-enemySpeed,0,0);
	}
}
