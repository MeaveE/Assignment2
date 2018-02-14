using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class PlayerControl : MonoBehaviour {
	
	public float speed;
	public Boundary boundary;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.AddForce (movement*speed);
		rb2d.position = new Vector2
			(
				Mathf.Clamp(rb2d.position.x, boundary.xMin, boundary.xMax),
				Mathf.Clamp(rb2d.position.y, boundary.yMin, boundary.yMax)
			);
	}
}
