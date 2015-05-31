using UnityEngine;
using System.Collections;

public class HitExit : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "Player") {

			Debug.Log ("Exit wurde getroffen");
			Application.LoadLevel ("Level");
			GameObject.Find ("_Settings").GetComponent<Score> ().addStage ();
		}
	}
}
