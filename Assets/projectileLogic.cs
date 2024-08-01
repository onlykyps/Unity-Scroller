using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileLogic : MonoBehaviour {

	public float projectileSpeed = 1.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveProjectileRight ();
	}

	void moveProjectileRight()
	{
		transform.Translate (projectileSpeed, 0, 0);
	}
}
