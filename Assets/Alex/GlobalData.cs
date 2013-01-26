using System;

namespace AssemblyCSharp
{
	public struct PlayerModel {
		public string name;
		public string resourceName;
		
		public PlayerModel(string name, string resourceName){
			this.name = name;
			this.resourceName = resourceName;
		}
		
	}
	public class GlobalData
	{
		
		public static PlayerModel ActivePlayerModel { get; set; }
		
		public static PlayerModel[] GetPlayerModels(){
			PlayerModel[] retval = {
				new PlayerModel("Dragonfly","DragonFly"),
				
			};
			return retval;
		}
	}
}

