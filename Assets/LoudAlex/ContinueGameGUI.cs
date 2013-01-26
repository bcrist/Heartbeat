using UnityEngine;
using AssemblyCSharp;

public class ContinueGameGUI : MonoBehaviour 
{
	
	public int menuNumber = 0;
	public GUISkin skin;
	// Use this for initialization
	void Start () {
	
	}
	void OnGUI()
	{
		GUI.skin = skin;
		if(menuNumber == 1){
			LevelList ll = new LevelList();
			ll.tempFill();
			ll.listToButtons();
		} else {
			// Make a background box
			GUI.Box(new Rect(10,10,120,90), "Continue Menu");
	
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			if(GUI.Button(new Rect(20,40,100,20), "Continue")) 
			{
				//leveltag will be set equal to that actual level tag as a string
				Application.LoadLevel(Application.loadedLevel);
			}
	
			// Make the second button.
			if(GUI.Button(new Rect(20,70,100,20), "Level Select")) 
			{
				menuNumber = 1;
			}
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
