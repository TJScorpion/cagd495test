using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public GameObject target1;
	public GameObject target2;
	public float speed = .25f;
	public Vector3 move;

	// Use this for initialization
	void Awake () {
		target1 = GameObject.FindGameObjectWithTag ("target1");
		target2 = GameObject.FindGameObjectWithTag ("target2");
		move = Vector3.right;


	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(move * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "target1") {
			move = Vector3.left;
		} else {
			move = Vector3.right;
		}
	}
}
