using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float speed; //How fast the player moves
	private float translation; //How the movement translates to in-game
	private float straffe; //How the player moves left and right, and how the player works with speed
	public GameObject subs; //getting game object and setting it to subs
	private bool isShowing; //isShowing = true or false

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked; //Locks the mouse into the game, so it's not going everywhere on the screen
	}
	
	// Update is called once per frame
	void Update () {

		translation = Input.GetAxis ("Vertical") * speed * Time.deltaTime; //translate W and S key presses to vertical movement
		straffe = Input.GetAxis ("Horizontal") * speed * Time.deltaTime; //translate A and D key presses to horizontal movement

		transform.Translate (straffe, 0, translation); //move the player
		if (Input.GetKeyDown ("escape")) {
			Cursor.lockState = CursorLockMode.None;
			//If esc is pressed, unlock the mouse from the game so you can close it.
		}
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			speed = 5;
			//If control is pressed down, set speed to 5
		} else if (Input.GetKeyUp (KeyCode.LeftControl)) {
			speed = 3;
			//if not, set speed to default
		}

		if (Input.GetKeyDown (KeyCode.E)) { 
			isShowing = !isShowing;
			subs.SetActive (isShowing);
			//If key pressed = E
			//isShowing = the reverse of what it originally was
			//set active subs
		}
	}
}
