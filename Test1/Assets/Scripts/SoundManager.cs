using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioSource Fire;
	public AudioSource Sad;
	public AudioSource Yes;


	
	// Update is called once per frame
	public void PlaySound (string clip) {
		
		switch (clip) {
		case "fire" :
			PlayFire();
			break;
		case "sad" :
			PlaySad();
			break;
		case "yes":
			PlayYes ();
			break;
		}
	}

	public void PlayFire()
	{
		//Debug.Log (Fire.name); didnt reach this code 
		Fire.Play();

	}

	public void PlaySad()
	{
		Sad.Play();
	}
	public void PlayYes()
	{
		Yes.Play ();
	}
}
