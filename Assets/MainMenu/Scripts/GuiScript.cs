using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class GuiScript : MonoBehaviour {
	
	/*
	 * 0 = Main Menu
	 * 1 = Character Select
	 */
	public int menuNumber = 0;
	
	protected PlayerModel[] modelOptions;

	// Use this for initialization
	void Start () {
		modelOptions = GlobalData.GetPlayerModels();
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
		GUI.Box(new Rect(10,10,160,60 + 30 * modelOptions.Length), "Select Player Model");
		
		int y = 40;
		for(int i=0; i<modelOptions.Length; ++i)
		{
			if(GUI.Button(new Rect(20,y,140,20), modelOptions[i].name)) {
				//	Select character and change to the right level
				Debug.Log (modelOptions[i].name + ": " + modelOptions[i].resourceName);
				GlobalData.ActivePlayerModel = modelOptions[i];
				Application.LoadLevel("AlexWork");
			}
			y += 30;
		}

		
		// Make the second button.
		if(GUI.Button(new Rect(20,y,140,20), "Cancel")) {
			menuNumber = 0;
		}
	}
	
	
	void menuMain() {
		// Make a background box
		GUI.Box(new Rect(10,10,100,120), "Loader Menu");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Start")) {
			menuNumber = 1;
		}
		
		if(GUI.Button(new Rect(20,70,80,20), "Credits")) {
			Application.LoadLevel("Credits");
		}

		// Make the second button.
		if(GUI.Button(new Rect(20,100,80,20), "Quit")) {
			Application.Quit();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
