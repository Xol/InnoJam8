using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow)) {
			GameObject.Find("up").GetComponent<SpriteRenderer>().enabled = false;
			GameObject.Find("up_marked").GetComponent<SpriteRenderer>().enabled = true;
		}
		if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.UpArrow)) {
			GameObject.Find("up").GetComponent<SpriteRenderer>().enabled = true;
			GameObject.Find("up_marked").GetComponent<SpriteRenderer>().enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow)) {
			GameObject.Find("down").GetComponent<SpriteRenderer>().enabled = false;
			GameObject.Find("down_marked").GetComponent<SpriteRenderer>().enabled = true;
		}
		if (Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.DownArrow)) {
			GameObject.Find("down").GetComponent<SpriteRenderer>().enabled = true;
			GameObject.Find("down_marked").GetComponent<SpriteRenderer>().enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			GameObject.Find("left").GetComponent<SpriteRenderer>().enabled = false;
			GameObject.Find("left_marked").GetComponent<SpriteRenderer>().enabled = true;
		}
		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.LeftArrow)) {
			GameObject.Find("left").GetComponent<SpriteRenderer>().enabled = true;
			GameObject.Find("left_marked").GetComponent<SpriteRenderer>().enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow)) {
			GameObject.Find("right").GetComponent<SpriteRenderer>().enabled = false;
			GameObject.Find("right_marked").GetComponent<SpriteRenderer>().enabled = true;
		}
		if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.RightArrow)) {
			GameObject.Find("right").GetComponent<SpriteRenderer>().enabled = true;
			GameObject.Find("right_marked").GetComponent<SpriteRenderer>().enabled = false;
		}
	
	}
}
