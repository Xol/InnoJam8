using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomObstacleGenerator : MonoBehaviour {

	private const int maxObstacleCount = 30;

	//duckWall
	/*private float duckWallMaxHeight = 7f;
	private int duckwallMaxCount = 5;

	//spikes
	private float spikesMinHeight = 2.183f;
	private float spikesMaxHeight = 15f;
	private int spikesMaxCount = 15;

	//stomp
	private float stompMaxHeight = 10f;
	private int stompMaxCount = 10;

	private GameObject Map;
	private float maxMapSizeX;
*/
	public Transform duckWall;
	public Transform spikes;
	public Transform stomp;

	private GameObject Map;
	private Transform actualObstacleType;
	private float startPosition, endPosition;
	private float maxMapSizeX;
	private float maxHeight;

	// Use this for initialization
	void Start () {
		List<Transform> transformList = new List<Transform>(){
			duckWall, spikes, stomp
		};

		Map = GameObject.Find ("Cube");
		maxMapSizeX = Map.transform.localScale.x;

		startPosition = (-1) * maxMapSizeX / 2;
		endPosition = maxMapSizeX / 2;

		Debug.Log("maxMapSizeX: " + maxMapSizeX + "; startPosition: " + startPosition + "; endPosition: " + endPosition);

		for(int i = 0; i < maxObstacleCount; i++){
			actualObstacleType = transformList[Random.Range(0, transformList.Count)];

			if(actualObstacleType == duckWall){
				maxHeight = 8f;
			}else if(actualObstacleType == spikes){
				maxHeight = Random.Range(2,15);
			}else if(actualObstacleType == stomp){
				maxHeight = 15;

			}

			//Eigenschaften zum nächsten Vecto
			Vector3 tmpVector = new Vector3((float)startPosition,(float)maxHeight,0f);
			//DEBUGAUSGABE
			Debug.Log("tmpVector: " + tmpVector.x + "; endPosition: " + endPosition);
			if(tmpVector.x >= endPosition)
				break;

			Instantiate(actualObstacleType, tmpVector, Quaternion.identity);
			if(!(actualObstacleType == spikes))
				startPosition += Random.Range(20,100);
			else
				startPosition += Random.Range(5,30);
		}

	}

	/*
	void Update () {
		Debug.Log ("Maximale Kartengröße: " + maxMapSizeX);
	}
	*/
}
