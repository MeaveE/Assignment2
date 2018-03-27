using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioSource fire;
	public AudioSource die;

	
	// Update is called once per frame
	public void PlaySound (string clip) {
		
		switch (clip) {
		case "fire" :
			PlayFire();
			break;
		case "die" :
			PlayDie();
			break;
		}
	}

	public void PlayFire()
	{
		fire.Play();
	}

	public void PlayDie()
	{
		die.Play();
	}
}
