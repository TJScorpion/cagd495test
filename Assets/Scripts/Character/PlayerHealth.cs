using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int health = 5;

	// Use this for initialization
	void Awake () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (health == 0) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}

	void OnCollision(Collision col){
		if (col.gameObject.tag == "enemy") {
			health--;
		}
	}
}
