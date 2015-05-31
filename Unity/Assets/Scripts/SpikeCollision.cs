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
			GameObject.Find ("GameOver").transform.position =  GameObject.Find ("GameOver").transform.position - new Vector3(0,0,-10);
			GameObject.Find ("GameOverScore").GetComponent<TextMesh>().text = GameObject.Find("Player").GetComponent<PlayerScore>().getCoins().ToString();
			GameObject.Find ("GameOverTime").GetComponent<TextMesh>().text = GameObject.Find("_Settings").GetComponent<Score>().getTime();
			GameObject.Find ("GameOverStage").GetComponent<TextMesh>().text = "Stage " + GameObject.Find("_Settings").GetComponent<Score>().getStage();
			GameObject.Find ("HeroDies").GetComponent<AudioSource>().Play();
			Destroy(GameObject.Find ("Music"));
			GameObject.Find ("GameOverMusic").GetComponent<AudioSource>().Play();
			GameObject.Find("Player").GetComponent<PlayerScore>().resetCoins();
			GameObject.Find("_Settings").GetComponent<Score>().resetTime();
			GameObject.Find("_Settings").GetComponent<Score>().resetStage();
			GameObject.Find("_Settings").GetComponent<RestartScript>().setIsDead(true);
			for (int i = 0; i < bodyParts.Length*3; i++) {
				GameObject newObj = Instantiate(bodyPartsPrefab, collision.transform.position, Quaternion.identity) as GameObject;
				Destroy(collision.gameObject);
				GameObject.Find("Main Camera").GetComponent<CameraMovement>().setPlayer(newObj);
				newObj.GetComponent<SpriteRenderer>().sprite = bodyParts[Random.Range(0, bodyParts.Length)];
				int randVal = Random.Range(-300,300);
				newObj.GetComponent<Rigidbody>().velocity = new Vector3(randVal,randVal,randVal);
			}
		}
	}
}
