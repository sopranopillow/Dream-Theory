using UnityEngine;
using System.Collections;

public class Offsets : MonoBehaviour {

	public GameObject objects;

	// Use this for initialization
	void Start () {
		objects.GetComponent<Renderer> ().material.mainTextureOffset = new Vector2(objects.GetComponent<Renderer> ().transform.transform.position.x + .3f,0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
