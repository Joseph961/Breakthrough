using UnityEngine;
using System.Collections;

public class MovePaddle : MonoBehaviour {

	bool right =false;
	bool left = false;
	public float speed;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	//	mouse = Input.mousePosition.x;

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float moveHorizontal = Input.GetAxis ("Horizontal");


		if (moveHorizontal > 0 && !right) 
		{
						right = true;
						transform.Rotate (new Vector3 (0, 0, -15));
			if (left){
				left = false;
				transform.Rotate (new Vector3 (0, 0, -15));
			}
		} else if (moveHorizontal < 0 && !left) {
			left = true;
			transform.Rotate (new Vector3 (0, 0, 15));
			if(right){
				transform.Rotate (new Vector3 (0, 0, 15));
				right = false;
			}
		} else {


		}


		if ((rb.position.x < 7 && moveHorizontal > 0) ||(rb.position.x > -7 && moveHorizontal < 0)) {
						Vector3 movement = new Vector3 (moveHorizontal + rb.position.x, rb.position.y, rb.position.z);
			rb.MovePosition (movement);
				}

		//if(moveHorizontal > 0)

		//rb.AddForce (movement * speed);

	
	}
}
