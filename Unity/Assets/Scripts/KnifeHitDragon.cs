using UnityEngine;
using System.Collections;

public class KnifeHitDragon : MonoBehaviour {

	public GameObject dragon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Head") {
			Debug.Log ("Treffer");
		}
		
	}
}
