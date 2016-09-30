using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;

public class MenuScript : MonoBehaviour 
{
	

	public void PlayGame()
	{
		EditorSceneManager.LoadScene (1);
	}

	public void Quit()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif 
	}
}
