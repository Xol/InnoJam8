using UnityEngine;
using System.Collections;

public class DragonHeadMovement : MonoBehaviour {

	private int count;
	private int dir;

	// Use this for initialization
	void Start () {
		count = 100;
		dir = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 0) {
			count = 100;
			dir *= -1;
		}
		count --;
		Vector3 dirVec = new Vector3 ();
		if (dir == 1) {
			dirVec = Vector3.up;
		} else {
			dirVec = Vector3.down;
		}
		transform.Translate(dirVec * Time.deltaTime, Space.World);

	}
}
