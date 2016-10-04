using UnityEngine;
using System.Collections;

public class TotemActivator : MonoBehaviour {

	public GameObject obj;

	public float timer= 0.0f; // begins at this value
	public float timerMax = 5.0f; // event occurs at this value

	public bool act=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E))
		{
			act = true;
		}

		if (act == true) {
			obj.SetActive (true);

			timer += Time.deltaTime;


			if (timer >= timerMax)
			{
				Debug.Log(timer);
				#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
				#else
				Application.Quit();
				#endif 

			}
		}
	}
}
