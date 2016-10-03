using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class sound_oneshot : MonoBehaviour {
	public AudioClip on;
	public AudioClip off;
	AudioSource audio;
	public KeyCode key;
	bool enabled;
	void Start() {
		audio = GetComponent<AudioSource>();
		key = GetComponent<KeyCode>();
		enabled = false;
	}

	void Update() {
		if(Input.GetKeyDown(KeyCode.F) && enabled == false){
			audio.PlayOneShot(on, 0.7F);
			enabled = !enabled;
		}else if(Input.GetKeyDown(KeyCode.F) && enabled == true){
			audio.PlayOneShot(off, 0.7F);
			enabled = !enabled;
		}

	}
}