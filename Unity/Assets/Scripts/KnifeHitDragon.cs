using UnityEngine;
using System.Collections;

public class KnifeHitDragon : MonoBehaviour {

	private GameObject dragon;
	private GameObject dragonhead;
	private GameObject dragonBody;
	public GameObject bodyPartsPrefab;
	public Sprite dead_head;


	Sprite[] bodyParts;

	// Use this for initialization
	void Start () {
		bodyParts = Resources.LoadAll <Sprite>("Dragon/parts");
		dragonhead = GameObject.Find ("DragonHead");
		dragonBody = GameObject.Find ("DragonBody");
		dragon = GameObject.Find ("Dragon");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name == "DragonHead") {
			Destroy(this);
			Destroy(dragonBody);
			Destroy(collision.gameObject.GetComponent<SpikeCollision>());
			collision.gameObject.GetComponent<SpriteRenderer>().sprite = dead_head;
			Destroy(dragon.GetComponent<DragonAnimation>());
			for (int i = 0; i <= bodyParts.Length; i++) {
				GameObject newObj = Instantiate(bodyPartsPrefab, collision.transform.position, Quaternion.identity) as GameObject;			
				newObj.GetComponent<SpriteRenderer>().sprite = bodyParts[Random.Range(0, bodyParts.Length)];
				int randVal = Random.Range(-50,50);
				newObj.GetComponent<Rigidbody>().velocity = new Vector3(randVal,randVal,randVal);
				newObj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
			}
			Rigidbody rbHead = dragonhead.AddComponent<Rigidbody>();
			//rbHead.constraints = RigidbodyConstraints.FreezePositionZ;
			GameObject.Find ("Player").GetComponent<PlayerScore>().addCoins(10);
		}
		
	}
}
