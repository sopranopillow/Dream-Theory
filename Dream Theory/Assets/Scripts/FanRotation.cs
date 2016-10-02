using UnityEngine;
using System.Collections;

public class FanRotation : MonoBehaviour {

	public Transform playerTransform;

    public float fanspeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playerTransform.Rotate(0, fanspeed, 0);
	}
}
