using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerControlsWASD : MonoBehaviour {


	float maxPlayerY = 8.0f;
	float maxPlayerX = 20.0f;
	float playerCollisionOffset = 3.0f;

	public float playerSpeed = 3.0f;
	public GameObject projectile;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		movement ();
		spawnProjectileOnKey ();
	} 



	void movement()
	{
		if (Input.GetKey (KeyCode.W) && transform.position.y <= maxPlayerY) 
		{
			transform.Translate (0, playerSpeed, 0);
		}

		if (Input.GetKey (KeyCode.A) && transform.position.x >= -maxPlayerX) 
		{
			transform.Translate (-playerSpeed, 0, 0);
		}

		if (Input.GetKey (KeyCode.S) && transform.position.y >= -maxPlayerY) 
		{
			transform.Translate (0, -playerSpeed, 0);
		}

		if (Input.GetKey (KeyCode.D) && transform.position.x <= maxPlayerX) 
		{
			transform.Translate (playerSpeed, 0, 0);
		}
	}

	void spawnProjectileOnKey()
	{
		if (Input.GetKeyDown (KeyCode.K)) 
		{
			spawnProjectile ();
		}

	}

	void spawnProjectile()
	{
		Instantiate(projectile, new Vector3(transform.position.x + playerCollisionOffset, transform.position.y+ playerCollisionOffset,0), Quaternion.identity);
	}

	void onCollsionEnter2D(Collision2D tempCollision)
	{
		if(tempCollision.gameObject.tag == "Collision")
		{
			SceneManager.LoadScene ("Scene_1");
		}
	}






}
