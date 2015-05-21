using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	//public float speed;
	Rigidbody rb;

	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		//	mouse = Input.mousePosition.x;
		Vector3 movement = new Vector3 (0.0f, -10.0f, 0.0f);
		rb.AddForce (movement * 100);
		rb.velocity = (movement * -1);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	//	float moveHorizontal = Input.GetAxis ("Horizontal");
		
	//	Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		
	//	rb.AddForce (movement * speed);
		
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Brick")) 
		{
			other.gameObject.SetActive (false);


		}
	}

}
