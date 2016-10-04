using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class NextFinalLevel : MonoBehaviour {

	private Transform playerTransform;

	public float fallArea;

	public int sceneNum;

	public GameObject gameObj;

	// Use this for initialization
	void Start () {

		playerTransform = gameObj.transform;
	}

	// Update is called once per frame
	void Update () {
		if (playerTransform.position.y<fallArea)
		{
			EditorSceneManager.LoadScene(sceneNum);
		}

		Debug.Log("X= " + playerTransform.position.x);
		Debug.Log("Y= " + playerTransform.position.y);
		Debug.Log("Z= " + playerTransform.position.z);

	}
}
