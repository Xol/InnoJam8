using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Vector3 speed;
	public Vector3 invSpeed;
	private Rigidbody rb;
	private BoxCollider bc;
	private Vector3 boxColliderSize;

	// Use this for initialization
	void Start () {
		speed = new Vector3 (10, 0, 0);
		invSpeed = -1 * speed;
		rb = this.gameObject.GetComponent<Rigidbody> ();
		bc = this.gameObject.GetComponent<BoxCollider> ();
		boxColliderSize = bc.size;
		//rb.centerOfMass = new Vector3 (-1.3f, -1.3f, 0);
	}
	
	// Update is called once per frame
	void Update () {
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

			if (rb.velocity.y >= (float)(-0.1) && rb.velocity.y <= (float)(0.1)) {
				bc.size = new Vector3 (boxColliderSize.x, boxColliderSize.y / 2, bc.size.z);
				bc.center = new Vector3(0,-1,0);
			} else {
				bc.size = boxColliderSize;
				bc.center = Vector3.zero;
			}
		} else {
			bc.size = boxColliderSize;
			bc.center = Vector3.zero;
		}

		if (this.transform.position.y <= 4f) {
			transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.identity, 250 * Time.deltaTime );		
		}
	}
}
