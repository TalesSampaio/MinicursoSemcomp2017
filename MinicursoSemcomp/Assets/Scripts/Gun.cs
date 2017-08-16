using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	[SerializeField]
	GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Shoot();
		}
	}
	
	void Shoot () {
		Instantiate((GameObject)bulletPrefab, transform.position, transform.rotation);
	}
}
