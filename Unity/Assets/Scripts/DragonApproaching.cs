using UnityEngine;
using System.Collections;

public class DragonApproaching : MonoBehaviour {

	public GameObject dragon;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (dragon && player) {
			if (dragon.transform.position.x - player.transform.position.x <= 200) {
				if(GameObject.Find ("_Settings").GetComponent<Score>().getTimeInt() % 2 == 0)
					GameObject.Find ("dragonapproaching").GetComponent<SpriteRenderer>().enabled = true;
				else 
					GameObject.Find ("dragonapproaching").GetComponent<SpriteRenderer>().enabled = false;
				
			}
		}	
	}
}
