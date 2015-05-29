using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		offset = new Vector3 (0, 9, -15);
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = player.transform.position + offset;
	
	}
}
