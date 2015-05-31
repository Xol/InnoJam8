using UnityEngine;
using System.Collections;

public class HitExit : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		Debug.Log("Exit wurde getroffen");
		//Restart level
	}
}
