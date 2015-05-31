using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

	private GameObject player;
	private SpriteRenderer sr;
	public Sprite[] run;
	public Sprite[] fly;
	public Sprite[] duck;
	private int index;
	private float FPS;
	/**
	 * 1 = run
	 * 2 = fly
	 * 3 = duck
	 **/
	private int aniMode;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer> ();
		FPS = 30;
		aniMode = 1;
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {

		if (aniMode == 1) {
			if (run.Length == 0)
				return;
			float index = Time.time * FPS;
			index = index % run.Length;
			sr.sprite = run [(int)index];
		} else if (aniMode == 2) {
			if (fly.Length == 0)
				return;
			float index = Time.time * FPS;
			index = index % fly.Length;
			sr.sprite = fly [(int)index];
		} else if (aniMode == 3) {
			if (duck.Length == 0)
				return;
			float index = Time.time * FPS;
			index = index % duck.Length;
			sr.sprite = duck [(int)index];
		}

		if (player.transform.position.y <= 3f && aniMode != 3) {
			aniMode = 1;		
		} 
		if(player.transform.position.y > 3f) {
			aniMode = 2;
		}

	}

	public void setAniMode(int mode) {
		aniMode = mode;
	}
}
