using UnityEngine;
using System.Collections;

public class DragonAnimation : MonoBehaviour {
	private GameObject head;
	private GameObject body;

	private Sprite[] middleHead;
	private Sprite[] middleBody;

	private Sprite[] topHead;
	private Sprite[] topBody;

	private Sprite[] bottomHead;
	private Sprite[] bottomBody;

	private int index;
	private float FPS;

	private SpriteRenderer srHead;
	private SpriteRenderer srBody;

	private int randomCount;
	private int randomVal;

	// Use this for initialization
	void Start () {
		head = GameObject.Find ("DragonHead");
		body = GameObject.Find ("DragonBody");
		middleHead = Resources.LoadAll<Sprite>("Dragon/mitte/head");
		middleBody = Resources.LoadAll<Sprite>("Dragon/mitte/body");
		topHead = Resources.LoadAll<Sprite>("Dragon/oben/head");
		topBody = Resources.LoadAll<Sprite>("Dragon/oben/body");
		bottomHead = Resources.LoadAll<Sprite>("Dragon/unten/head");
		bottomBody = Resources.LoadAll<Sprite>("Dragon/unten/body");

		FPS = 20;

		srHead = head.GetComponent<SpriteRenderer> ();
		srBody = body.GetComponent<SpriteRenderer> ();

		randomCount = 150;
		randomVal = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (middleHead.Length == 0)
			return;
		float index = Time.time * FPS;
		index = index % middleHead.Length;




		randomCount--;
		if (randomCount <= 0) {
			randomCount = (int)Random.Range (150, 300);
			randomVal = Random.Range(1,4);
			Debug.Log (randomVal);
		}
		if (randomVal == 1) {
			srHead.sprite = middleHead [(int)index];
			head.transform.localPosition = new Vector3(-0.722f,0.254f,0f);
			srBody.sprite = middleBody [(int)index];
		} else if (randomVal == 2) {
			srHead.sprite = topHead [(int)index];
			head.transform.localPosition = new Vector3(0.903f,1.375f,0f);
			srBody.sprite = topBody [(int)index];
		} else if (randomVal == 3) {
			srHead.sprite = bottomHead [(int)index];
			head.transform.localPosition = new Vector3(-1.85f,-0.72f,0f);
			srBody.sprite = bottomBody [(int)index];
		}
	
	}
}
