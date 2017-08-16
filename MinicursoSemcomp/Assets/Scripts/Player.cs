using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField]
	float speed = 1;
	[SerializeField]
	int screenHorizontalLimit = 18;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A) && transform.position.x - speed > -screenHorizontalLimit) {
			transform.Translate(Vector3.right * -speed);
		}
		
		if (Input.GetKey(KeyCode.D) && transform.position.x + speed < screenHorizontalLimit) {
			transform.Translate(Vector3.right * speed);
		}
	}
}
