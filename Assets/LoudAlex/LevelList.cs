using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AssemblyCSharp
{
	public class LevelList
	{
		public GUISkin skin;
		public string[] levels;
		
		public void tempFill ()
		{
			//temp!!!! this will be replaced when we actually have a level list
			List<string> l1 = new List<string>();
			l1.Add("Level 1");
			l1.Add("Level 2");
			l1.Add("Level 3");
			l1.Add("Level 4");
			l1.Add("Level 5");
			levels = l1.ToArray();
		}
		public void listToButtons ()
		{
			GUI.skin = skin;
			
			int p = 40;
			int q = 0;
			int lim = 280;
			int x = 20;
			GUI.Box(new Rect(10,10,300,300), "Level Select Menu");
			foreach( string level in levels)
			{
				string levelTag = level;
				if(GUI.Button(new Rect(x,p + q,60, 20), levelTag)) 
				{
					//leveltag will be set equal to that actual level tag as a string
					Application.LoadLevel(levelTag);
				}
				q = q + 30;
				if( p + q == lim)
				{
					q = 0;
					x = x + 60;
				}
			}
		}
		public LevelList ()
		{
			
			
		}
		
	}
}

