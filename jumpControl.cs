using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpControl : MonoBehaviour {

	Rigidbody player; // Allows what rigidbody the player will be
	public float jumpForce = 3f; //how much force you want when jumping
	private bool onGround; //Player on ground or not

	private void Awake() {
		GameObject playerGameObject = GameObject.FindGameObjectWithTag ("player");
		player = playerGameObject.GetComponent<Rigidbody> ();
	}
	// Use this for initialization
	void Start () {
		//grabs the rigidbody from the player
		player = GetComponent<Rigidbody> ();
		//player is on ground
		onGround = true;
	}
	
	// Update is called once per frame
	void Update () {
		//checks if the button "jump" (space) is pressed, and the player is on the ground
		if (Input.GetButton("Jump") && onGround == true) {
			//adds force to the player in the y axis
			player.velocity = new Vector3 (0f, jumpForce, 0f);
			//says the player is no longer on the ground
			onGround = false;
		}
	}

	//checks if player has hit a collider
	void OnCollisionEnter(Collision other) {
		//checks if collider is tagged "ground"
		if (other.gameObject.CompareTag ("ground")) {
			//if it is, player is on ground
			onGround = true;
		}
	}
}
