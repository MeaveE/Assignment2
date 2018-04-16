using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public static int scoreValue = 0;
	Text score;

	// Use this for initialization
	void Start () {
		score = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + scoreValue;

		if (scoreValue < 0) {
			score.text = "Game Over!";
			Time.timeScale = 0;
		}
		if (scoreValue > 250) {
			score.text = "You Win!";
			Destroy (GameObject.FindWithTag("Enemy"));
			Time.timeScale = 0;

		}
		
	}
}
