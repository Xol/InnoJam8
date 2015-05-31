using UnityEngine;
using System.Collections;

public class CoinCollider : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		Debug.Log ("Collider mit: " + other.gameObject.name);
		Destroy (this.gameObject);
	}
}
