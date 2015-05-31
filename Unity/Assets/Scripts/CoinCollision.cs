using UnityEngine;
using System.Collections;

public class CoinCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collision) {
		if (collision.gameObject.name == "Player") {
			Destroy(this.gameObject);
			collision.gameObject.GetComponent<PlayerScore>().addCoin();
			GameObject.Find ("CollectCoin").GetComponent<AudioSource>().Play();
		}
	}
}
