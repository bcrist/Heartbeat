using UnityEngine;
using System.Collections;

public class GuiScript : MonoBehaviour {
	
	/*
	 * 0 = Main Menu
	 * 1 = Character Select
	 */
	public int menuNumber = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnGUI(){
		if(menuNumber == 1){
			menuCharacterSelect();			
		} else {
			menuMain();
		}
			
	}
	
	void menuCharacterSelect(){
		// Make a background box
		GUI.Box(new Rect(10,10,100,180), "Loader Menu");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Adam")) {
			//	Select character and change to the right level
			Application.LoadLevel("TestLevel");
		}

		// Make the second button.
		if(GUI.Button(new Rect(20,70,80,20), "Buddy")) {
			Application.LoadLevel("TestLevel");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,100,80,20), "Charlie")) {
			Application.LoadLevel("TestLevel");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,130,80,20), "Meth Addict")) {
			Application.LoadLevel("TestLevel");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,160,80,20), "Cancel")) {
			menuNumber = 0;
		}
	}
	
	
	void menuMain() {
		// Make a background box
		GUI.Box(new Rect(10,10,100,90), "Loader Menu");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Start")) {
			menuNumber = 1;
		}

		// Make the second button.
		if(GUI.Button(new Rect(20,70,80,20), "Quit")) {
			Application.Quit();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
