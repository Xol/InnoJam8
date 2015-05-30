using UnityEngine;
using System.Collections;

public class SpringBehavior : MonoBehaviour {
	
	void OnTriggerEnter (Collider col)
	{
		Debug.Log ("DEBUG: OnCollisionEnter(); gameObject.name: " + col.gameObject.name);
		if(col.gameObject.name == "Player")
		{
			Debug.Log ("If; Name of gameObject: " + col.gameObject.name);
			Destroy(this.gameObject);
			col.gameObject.GetComponent<PlayerMovement>().toggleFly();
		}
	}
}
