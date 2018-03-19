using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;

	private float randY;
	Vector2 wheretoSpawn;
	public float spawnRate;
	float nextSpawn=0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > nextSpawn) {
			nextSpawn = Time.time + spawnRate;
			randY = Random.Range (-2.4f,6.4f);
			wheretoSpawn = new Vector2 (transform.position.x, randY);
			Instantiate (enemy, wheretoSpawn, Quaternion.identity);
		}

	}
}
