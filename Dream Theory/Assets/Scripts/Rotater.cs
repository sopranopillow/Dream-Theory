using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	public Transform playerTransform;

	public float yspeed;

	public float xspeed;

	public float zspeed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		playerTransform.Rotate(xspeed, yspeed, zspeed);
	}
}
