using UnityEngine;
using System.Collections;

public class Musik : MonoBehaviour {

	public AudioClip otherClip;
	AudioSource audio;
	
	void Start() {
		audio = GetComponent<AudioSource>();
	}
	
	void Update() {
		if (!audio.isPlaying) {
			audio.clip = otherClip;
			audio.Play();
			audio.loop = true;
		}
	}
}
