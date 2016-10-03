using UnityEngine;
using System.Collections;

public class flashlight : MonoBehaviour {

	public Light flashlight2;

	// Use this for initialization
	void Start () {
		
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.F) && flashlight2.enabled == false){
			flashlight2.enabled = true;
		}else if(Input.GetKeyDown(KeyCode.F) && flashlight2.enabled == true){
			flashlight2.enabled = false;
		}
	}

}