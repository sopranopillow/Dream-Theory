using UnityEngine;
using System.Collections;

public class FanRotation : MonoBehaviour {

	public Transform playerTransform;

	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag("Rotater").transform;
	}
	
	// Update is called once per frame
	void Update () {
		playerTransform.Rotate(0, 0.2f, 0);
	}
}
