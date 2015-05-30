using UnityEngine;
using System.Collections;

public class StompBehavior : MonoBehaviour {
	private const int speedUp = 10;
	private const float minStompPosition = 4.8f;
	private const float maxStompPosition = 15f;
	Vector3 direction;
	void Start () {
		direction = Vector3.down;
	}
	// Update is called once per frame
	void Update () {
		double position = this.transform.position.y;
		transform.Translate(direction * speedUp * Time.deltaTime);

		if(transform.position.y >= maxStompPosition){
			direction = Vector3.down;
		}
		
		if(transform.position.y <= minStompPosition){
			direction = Vector3.up;    
		}
	}
}

