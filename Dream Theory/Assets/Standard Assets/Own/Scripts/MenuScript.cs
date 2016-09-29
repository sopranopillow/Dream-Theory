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
		Application.Quit ();
	}
}
