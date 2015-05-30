using UnityEngine;
using System.Collections;

public class RandomObstacleGenerator : MonoBehaviour {

	//duckWall
	private float duckWallMaxHeight = 7f;
	private int duckwallMaxCount = 5;

	//spikes
	private float spikesMinHeight = 2.183f;
	private float spikesMaxHeight = 15f;
	private int spikesMaxCount = 15;

	//stomp
	private float stompMaxHeight = 10f;
	private int stompMaxCount = 10;

	private GameObject Map;
	private double maxMapSizeX;

	public Transform duckWall;
	public Transform spikes;
	public Transform stomp;
	// Use this for initialization
	void Start () {
		Map = GameObject.Find ("Cube");
		maxMapSizeX = Map.transform.localScale.x;

		//Generierung der obstacles duckWall
		for(int i = 0; i < duckwallMaxCount; i++){
			//Instantiate (duckWall, new Vector3 ((float)Random.Range(-1)*(int)maxMapSizeX/2, (int)(maxMapSizeX/2)), duckWallMaxHeight, 0f), Quaternion.identity);
			Instantiate (duckWall, new Vector3 ((float)Random.Range((-1)*(int)maxMapSizeX/2, (int)(maxMapSizeX/2)), duckWallMaxHeight, 0f), Quaternion.identity);
		}

		//Generierung der obstacles spikes
		for(int i = 0; i < spikesMaxCount; i++){
			//TODO: Der indirekte Cast ist natürlich bei floats nicht so schön. Das muss ausgebessert werden.
			Instantiate (spikes, new Vector3 ((float)Random.Range((-1)*(int)maxMapSizeX/2, (int)(maxMapSizeX/2)), (float)Random.Range((int)spikesMinHeight,(int)spikesMaxHeight), 0f), Quaternion.identity);
		}

		//Generierung der obstacles stomp
		for(int i = 0; i < spikesMaxCount; i++){
			//TODO: Der indirekte Cast ist natürlich bei floats nicht so schön. Das muss ausgebessert werden.
			Instantiate (stomp, new Vector3 ((float)Random.Range((-1)*(int)maxMapSizeX/2, (int)(maxMapSizeX/2)), stompMaxHeight, 0f), Quaternion.identity);
		}

		//Generierung der obstacles 
	}


	/*
	void Update () {
		Debug.Log ("Maximale Kartengröße: " + maxMapSizeX);
	}
	*/
}
