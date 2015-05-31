using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	private GameObject player;
	public GameObject score, score1;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
		score.GetComponent<TextMesh> ().text = player.GetComponent<PlayerScore> ().getCoins ().ToString();
		score1.GetComponent<TextMesh> ().text = player.GetComponent<PlayerScore> ().getCoins ().ToString();

	}
}
