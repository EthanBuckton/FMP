using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CCSElav : MonoBehaviour {

	//checks if the player hits the object this script is bound to
	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.tag == "player")
			//if the player does hit it, load the scene that has 1 as it's load number
			SceneManager.LoadScene (3);
			//Application.LoadLevel (1);
			
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
