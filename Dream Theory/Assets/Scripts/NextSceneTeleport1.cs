using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class NextSceneTeleport1 : MonoBehaviour {

    private Transform playerTransform;

	// Use this for initialization
	void Start () {

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (playerTransform.position.y<19)
        {
            EditorSceneManager.LoadScene(2);
        }

        Debug.Log("X= " + playerTransform.position.x);
        Debug.Log("Y= " + playerTransform.position.y);
        Debug.Log("Z= " + playerTransform.position.z);

    }
}
