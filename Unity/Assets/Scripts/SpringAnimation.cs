using UnityEngine;
using System.Collections;

public class SpringAnimation : MonoBehaviour {

	public Sprite[] idle;
	private int index;
	private float FPS;

	// Use this for initialization
	void Start () {
		idle = Resources.LoadAll<Sprite>("idle");
		FPS = 20;

	}
	
	// Update is called once per frame
	void Update () {
		if (idle.Length == 0)
			return;
		float index = Time.time * FPS;
		index = index % idle.Length;
		gameObject.GetComponent<SpriteRenderer>().sprite = idle [(int)index];
	}
}
