using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public float moveSpeed = 3;
	public GameObject blood;
	Transform LMove, RMove;
	Vector3 localScale;
	bool movingRight= true;
	Rigidbody2D rb;


	void Start()
	{
		localScale = transform.localScale;
		rb = GetComponent<Rigidbody2D> ();
		LMove = GameObject.Find ("LMove").GetComponent<Transform> ();
		RMove = GameObject.Find ("RMove").GetComponent<Transform> ();
	}

	void Update()
	{
		
		if (transform.position.x > RMove.position.x)
			movingRight = false;
		if (transform.position.x < LMove.position.x)
			movingRight = true;
		if (movingRight)
			moveRight ();
		else
			moveLeft ();
	}

	void moveRight()
	{
		movingRight = true;
		localScale.x = 1;
		transform.localScale = localScale;
		rb.velocity = new Vector2 (localScale.x * moveSpeed, rb.velocity.y);
	}
	void moveLeft()
	{
		movingRight = false;
		localScale.x = -1;
		transform.localScale = localScale;
		rb.velocity = new Vector2 (localScale.x * moveSpeed, rb.velocity.y);
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		//Debug.Log ("Collision name =" + col.gameObject);
		if (col.gameObject.tag.Equals ("Bullet")) {
			Instantiate (blood, transform.position, Quaternion.identity);
			Destroy (col.gameObject);
			Destroy (gameObject);
		}
	}
}
