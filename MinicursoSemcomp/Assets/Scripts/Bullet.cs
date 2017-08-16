using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	[SerializeField]
	float speed;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * speed);
	}
	
	void OnBecameInvisible () {
		Destroy(gameObject);
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.transform.parent) {
			Destroy(other.transform.parent.gameObject);
		}
	}
}
