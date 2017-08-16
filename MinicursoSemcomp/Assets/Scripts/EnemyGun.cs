using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour {
	[SerializeField]
	GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Shoot", 2, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void Shoot () {
		Instantiate((GameObject)bulletPrefab, transform.position, transform.rotation);
	}
}
