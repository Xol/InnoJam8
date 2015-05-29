using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Vector3 speed;
	public Vector3 invSpeed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		speed = new Vector3 (10, 0, 0);
		invSpeed = -1 * speed;
		rb = this.gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (rb.velocity);
		if (rb.velocity.x <= 25f && rb.velocity.x >= -25f) {
			if (Input.GetKey (KeyCode.LeftArrow)) {
				rb.AddForce (invSpeed);	
			} else {
				this.gameObject.GetComponent<Rigidbody> ().AddForce (speed);	
			}
		}
		if (Input.GetKey (KeyCode.RightArrow) && rb.velocity.x <= 35f) {
			rb.AddForce (speed * 2);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.useGravity = false;
			rb.AddForce (new Vector3(0,3,0));
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			rb.useGravity = true;

		}
	}
}
