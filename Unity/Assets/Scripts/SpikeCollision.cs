using UnityEngine;
using System.Collections;

public class SpikeCollision : MonoBehaviour {
	public GameObject bloodSplat;
	public GameObject bodyPartsPrefab;
	public Sprite[] bodyParts;

	// Use this for initialization
	void Start () {	
		bodyParts = Resources.LoadAll<Sprite>("BodyParts");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "Player") {
			Instantiate(bloodSplat,collision.transform.position, Quaternion.identity);
			for (int i = 0; i < bodyParts.Length*3; i++) {
				GameObject newObj = Instantiate(bodyPartsPrefab, collision.transform.position, Quaternion.identity) as GameObject;
				Destroy(collision.gameObject);
				GameObject.Find("Main Camera").GetComponent<CameraMovement>().setPlayer(newObj);
				newObj.GetComponent<SpriteRenderer>().sprite = bodyParts[Random.Range(0, bodyParts.Length)];
				int randVal = Random.Range(-300,300);
				newObj.GetComponent<Rigidbody>().velocity = new Vector3(randVal,randVal,randVal);
				Instantiate(bloodSplat,newObj.transform.position, Quaternion.identity);

			}
		}
	}
}
