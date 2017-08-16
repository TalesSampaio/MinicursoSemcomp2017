using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	[SerializeField]
	GameObject playerPrefab;
	[SerializeField]
	GameObject enemyPrefab;
	[SerializeField]
	Vector3 enemyPositionTemp;
	[SerializeField]
	Quaternion enemyRotationTemp;
	[SerializeField]
	float timeToSpawn;
	[SerializeField]
	float difficulty;
	
	float timeTemp;
	
	// Use this for initialization
	void Start () {
		InstantiatePlayer();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			ResetGame();
		}
		
		timeTemp += Time.deltaTime;
		
		if (timeTemp >= timeToSpawn) {
			InstantiateEnemy();
			timeTemp = 0;
			timeToSpawn = timeToSpawn/difficulty;
		}
	}
	
	void InstantiatePlayer () {
		Instantiate((GameObject)playerPrefab, Vector3.zero, Quaternion.identity);
	}
	
	void InstantiateEnemy () {
		enemyPositionTemp.x = Random.Range(-18f, 18f);
		Instantiate((GameObject)enemyPrefab, enemyPositionTemp, enemyRotationTemp);
	}
	
	void ResetGame () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
