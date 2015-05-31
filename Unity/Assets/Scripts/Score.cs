using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	private GameObject player;
	public GameObject score, score1, time1, time2;
	private static float time;
	private static int stage = 1;
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (player) {
			score.GetComponent<TextMesh> ().text = player.GetComponent<PlayerScore> ().getCoins ().ToString ();
			score1.GetComponent<TextMesh> ().text = player.GetComponent<PlayerScore> ().getCoins ().ToString ();
			time1.GetComponent<TextMesh> ().text = ((int)time).ToString ();
			time2.GetComponent<TextMesh> ().text = ((int)time).ToString ();
		}
	}

	public string getTime() {
		return ((int)time).ToString ();
	}
	public int getTimeInt() {
		return (int)time;

	}
	public string getStage() {
		return ((int)stage).ToString ();
	}
	public void addStage() {
		stage++;
	}
	public void resetTime() {
		time = 0;
	}
	public void resetStage() {
		stage = 1;
	}

}
