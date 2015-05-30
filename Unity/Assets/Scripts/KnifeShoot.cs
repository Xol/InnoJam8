using UnityEngine;
using System.Collections;

public class KnifeShoot : MonoBehaviour {

	public GameObject knife;
	public GameObject spawnPoint;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate(knife, spawnPoint.gameObject.transform.position, Quaternion.identity);
		}
	}
}