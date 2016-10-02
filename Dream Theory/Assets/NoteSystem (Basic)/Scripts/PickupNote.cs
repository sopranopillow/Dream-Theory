using UnityEngine;
using System.Collections;
using System;

public class PickupNote : MonoBehaviour {
	
	//Maximum Distance you Can Pick Up A Book
	public float maxDistance = 1.5F;
	
	//Your Custom GUI Skin with the Margins, Padding, Align, And Texture all up to you :)
	public GUISkin skin;
	
	//Are we currently reading a note?
	private bool readingNote = false;
	
	//The text of the note we last read
	private string noteText;

    private string Text = "There are no definite signs to distinguish dream experience from waking experience.therefore, It is possible that I am dreaming right now and that all of my perceptions are false".Replace("\n",
                                                         Environment.NewLine);


    void Start () {
		
		//Start the input check loop
		StartCoroutine ( CheckForInput () );
		
	}
	
	private IEnumerator CheckForInput () {
		
		//Keep Updating
		while (true) {
		
			//If the 'E' was pressed and not reading a note check for a note, else stop reading
			if (Input.GetKeyDown (KeyCode.E)) {
				
				if (!readingNote)
					CheckForNote ();
				else 
					readingNote = false;
			
			}
				
			//Wait One Frame Before Continuing Loop
			yield return null;
			
		}
		
	}
	
	private void CheckForNote () {
		
		//A ray from the center of the screen
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit data;
		
		//Did we hit something?
		if (Physics.Raycast (ray, out data, maxDistance)) {
			
			//Was the object we hit a note?
			if (data.transform.name == "Note") {
				
				//Get text of note, destroy the note, and set reading to true
				noteText = Text;
				Destroy (data.transform.gameObject);
				readingNote = true;
				
			}
			
		}
		
	}
	
	void OnGUI () {
		
		if (skin)
			GUI.skin = skin;
		
		//Are we reading a note? If so draw it.
		if (readingNote) {
			
			//Draw the note on screen, Set And Change the GUI Style To Make the Text Appear The Way you Like (Even on an image background like paper)
			GUI.Box (new Rect (Screen.width / 2.5F, Screen.height / 16F, Screen.width / 4F, Screen.height * 0.75F), noteText);

        }
		
	}
	
}
