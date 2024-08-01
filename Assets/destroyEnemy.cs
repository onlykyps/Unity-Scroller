using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour {

	public GameObject whiteExplosion;
	public GameObject pinkExplosion ;

	public scoreLogic addToScore;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D tempCollision)
	{
		if(tempCollision.gameObject.tag == "Collision")
		{
			spawnParticles (tempCollision.transform.position);
			callScoreLogicScript ();
			Destroy (tempCollision.gameObject);
		}

		if(tempCollision.gameObject.tag == "Projectile")
		{
			Destroy (tempCollision.gameObject);
		}
	}

	void callScoreLogicScript()
	{
		addToScore = GameObject.FindGameObjectWithTag ("GUI").GetComponent<scoreLogic>();
		addToScore.addToScoreVOID ();
	}

	void spawnParticles(Vector2 tempPosition)
	{
		Instantiate (whiteExplosion, tempPosition, Quaternion.identity);
		Instantiate (pinkExplosion, tempPosition, Quaternion.identity);
	}

}
