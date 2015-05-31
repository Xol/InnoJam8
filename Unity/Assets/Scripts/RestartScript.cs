using UnityEngine;
using System.Collections;

public class RestartScript : MonoBehaviour {

	private bool isDead;

	// Use this for initialization
	void Start () {
		isDead = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(isDead && Input.GetKeyDown(KeyCode.Space)) {
			Application.LoadLevel ("Level");


		}
	
	}

	public void setIsDead(bool _val) {
		isDead = _val;
	}
}
