using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomObstacleGenerator : MonoBehaviour {

	private const int maxObstacleCount = 30;
	private const int maxSprings = 40;
	private int coinCount;

	public Transform duckWall;
	public Transform spikes;
	public Transform stomp;
	public Transform spring;
	public Transform coin;

	private GameObject Map;
	private Transform actualObstacleType;
	private float startPosition, endPosition;
	private float maxMapSizeX;
	public float maxHeight;

	// Use this for initialization
	void Start () {
		generateObstacle ();
		generateSpringTraps ();
		generateCoins ();
	}

	private void generateObstacle(){
		List<Transform> transformList = new List<Transform>(){
			duckWall, spikes, stomp
		};
		
		Map = GameObject.Find ("Cube");
		maxMapSizeX = Map.transform.localScale.x;
		
		startPosition = ((-1) * maxMapSizeX / 2)+50;
		endPosition = maxMapSizeX / 2;
		for(int i = 0; i < maxObstacleCount; i++){
			actualObstacleType = transformList[Random.Range(0, transformList.Count)];
			
			if(actualObstacleType == duckWall){
				maxHeight = 8.5f;
			}else if(actualObstacleType == spikes){
				maxHeight = Random.Range(2,15);
			}else if(actualObstacleType == stomp){
				maxHeight = 15;
			}
			
			Vector3 tmpVector = new Vector3((float)startPosition,(float)maxHeight,0f);
			if(tmpVector.x >= (endPosition-50))
				break;
			
			Instantiate(actualObstacleType, tmpVector, Quaternion.identity);
			if(!(actualObstacleType == spikes))
				startPosition += Random.Range(20,100);
			else
				startPosition += Random.Range(5,30);
		}
	}

	private void generateSpringTraps(){
		startPosition = ((-1) * maxMapSizeX / 2)+50;
		
		for(int i = 0; i < maxSprings; i++){
			if(Random.Range (0,2)== 1){
				maxHeight = -0.5f;
			}else{
				maxHeight = 19.66f;
			}
			Vector3 tmpVector = new Vector3((float)startPosition,maxHeight,0f);
			if(tmpVector.x >= endPosition-50)
				break;
			Transform new_spring = (Transform)Instantiate(spring, tmpVector, Quaternion.identity);
			if(maxHeight == 19.66f ) {
				new_spring.eulerAngles = new Vector3(0,0,180);
				new_spring.GetComponent<SpringBehavior>().setIsTop(true);
			}
			startPosition += Random.Range(10,50);
		}
	}

	private void generateCoins(){
		coinCount = Random.Range (10, 31);
		startPosition = ((-1) * maxMapSizeX / 2)+50;
		
		for(int i = 0; i < coinCount; i++){
			maxHeight = Random.Range(-1,20);
			Vector3 tmpVector = new Vector3((float)startPosition,maxHeight,0f);
			if(tmpVector.x >= endPosition-50)
				break;
			Instantiate(coin, tmpVector, Quaternion.identity);
			startPosition += Random.Range(10,50);
		}

	}
}
