using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Vector3 speed;
	public Vector3 invSpeed;
	private Rigidbody rb;
	private BoxCollider bc;
	private Vector3 boxColliderSize;

	private bool flag = true;

	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3(0,-40f,0);
		speed = new Vector3 (15, 0, 0);
		invSpeed = new Vector3(-30,0,0);
		rb = this.gameObject.GetComponent<Rigidbody> ();
		bc = this.gameObject.GetComponent<BoxCollider> ();
		boxColliderSize = bc.size;
		//rb.centerOfMass = new Vector3 (-1.3f, -1.3f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (rb.velocity.x <= 20f && rb.velocity.x >= -20f) {
			if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
				rb.AddForce (invSpeed);	
			} else {
				this.gameObject.GetComponent<Rigidbody> ().AddForce (speed);	
			}
		}
		if (rb.velocity.x <= -20f) {
			rb.AddForce (speed);
		}
		if ((Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) && rb.velocity.x <= 35f) {
			rb.AddForce (speed * 2);
		}

		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) {
			rb.useGravity = false;
			rb.AddForce (new Vector3 (0, 3, 0));
		}
		if (Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.S)) {
			rb.useGravity = true;
			bc.size = new Vector3 (boxColliderSize.x, boxColliderSize.y / 3, bc.size.z);
			bc.center = new Vector3 (0, -.7f, 0);
			transform.GetChild (1).GetComponent<PlayerAnimation> ().setAniMode (3);
		} 
		if (Input.GetKeyUp (KeyCode.DownArrow) || Input.GetKeyUp (KeyCode.S)) {
			transform.GetChild (1).GetComponent<PlayerAnimation> ().setAniMode (1);
			bc.size = boxColliderSize;
			bc.center = Vector3.zero;

		}

		if (this.transform.position.y <= 3f) {
			transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.identity, 200 * Time.deltaTime);		
		}
	}
	public void toggleFly(bool is_top){
		if(!is_top) 
			rb.velocity = new Vector3 (Random.Range (-100,100),Random.Range (0,100), 0f);
		else
			rb.velocity = new Vector3 (Random.Range (-100,100),Random.Range (-100,0), 0f);

		//rb.velocity = new Vector3 (-100, 0, 0);
	}
}
