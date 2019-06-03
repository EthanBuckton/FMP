using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamLook : MonoBehaviour {

	[SerializeField]
	public float sensitivity = 5.0f; //sensitivity of the mouse
	[SerializeField]
	public float smoothing = 2.0f; //how smooth the mouse will move

	public GameObject player; //making the world player act like GameObject
	private Vector2 mouseLook; //Vector for detecting the mouse looking, in order to smooth it
	private Vector2 smoothV; //Vector for smoothinjg

	public float minimumY = -60F; //Stopping the player from rotating 360 degrees
	public float maximumY = 60F;

	// Use this for initialization
	void Start () {
		//Get's the GameObject player and sets that it can be transformed
		player = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		var md = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y")); //Lets the player move the mouse around to look
		md = Vector2.Scale (md, new Vector2 (sensitivity * smoothing, sensitivity * smoothing)); //Adds the smoothing and sensitivity, so the player can actually look

		smoothV.x = Mathf.Lerp (smoothV.x, md.x, 1f / smoothing); //Smooths on the x axis
		smoothV.y = Mathf.Lerp (smoothV.y, md.y, 1f / smoothing); //Smooths on the y axis

		float rotY = Mathf.Clamp (mouseLook.y, minimumY, maximumY); //Stops the player from rotating 360 degrees on the Y axis

		mouseLook += smoothV; //Adds the smoothing to the mouse

		transform.localRotation = Quaternion.AngleAxis (-rotY, Vector3.right); //Adds the rotation to the player
		player.transform.localRotation = Quaternion.AngleAxis (mouseLook.x, player.transform.up); //Adds the rotation to the player
}
}
