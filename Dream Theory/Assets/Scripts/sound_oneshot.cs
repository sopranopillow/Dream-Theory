using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class sound_oneshot : MonoBehaviour {
	public AudioClip impact;
	AudioSource audio;
	public KeyCode key;
	void Start() {
		audio = GetComponent<AudioSource>();
		key = GetComponent<KeyCode>();
	}

	void Update() {
		if(Input.GetKeyDown(KeyCode.F)){
			audio.PlayOneShot(impact, 0.7F);
		}	
	}
}