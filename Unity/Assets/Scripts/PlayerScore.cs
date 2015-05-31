using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {
	private static int cointCount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addCoin() {
		cointCount++;
	}

	public void addCoins(int val) {
		cointCount += val;
	}

	public void resetCoins() {
		cointCount = 0;
	}

	public int getCoins() {
		return cointCount;
	}


}
