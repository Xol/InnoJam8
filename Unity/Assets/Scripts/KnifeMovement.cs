using UnityEngine;
using System.Collections;

public class KnifeMovement : MonoBehaviour {

	private GameObject Player;
	private float speed;
	private Vector3 velVec;


	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		speed = 50;
		velVec = new Vector3 ();
		velVec.x = Mathf.Cos(Player.transform.eulerAngles.z * Mathf.Deg2Rad) * speed;
		velVec.y = Mathf.Sin(Player.transform.eulerAngles.z * Mathf.Deg2Rad) * speed;
		velVec.z = 0;
		this.transform.rotation = Player.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {

		this.gameObject.GetComponent<Rigidbody> ().velocity = velVec;

	}
}
