using UnityEngine;

public class ContinueGameGUI : MonoBehaviour 
{
	
	public int menuNumber = 0;
	// Use this for initialization
	void Start () {
	
	}
	void OnGUI()
	{
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
			menuNumber = 2;
			menuCharacterSelect();
		}
	}
	void menuCharacterSelect()
	{
		
		int x = 0;
		// Make a background box
		GUI.Box(new Rect(10,10,160,60 + 30 * modelOptions.Length), "Select Player Model");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
