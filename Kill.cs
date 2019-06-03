using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour {

	//if player collides with object script is attached to
	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.tag == "player")
			System.Threading.Thread.Sleep (1000);
		//destroy gameObject it's attached to
			Destroy (gameObject);
		//load ending scene
			SceneManager.LoadScene (4);


	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
