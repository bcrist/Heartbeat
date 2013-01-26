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
		private static PlayerModel mActivePlayerModel;
		private static bool mActivePlayerModelInitialized;
		public static PlayerModel ActivePlayerModel{
			get {
				if(!mActivePlayerModelInitialized){
					PlayerModel[] models = GetPlayerModels();
					mActivePlayerModel = models[new Random().Next (models.Length)];	
					mActivePlayerModelInitialized = true;
				}
				return mActivePlayerModel;
			}
			set {
				mActivePlayerModel = value;
				mActivePlayerModelInitialized = true;
			}
			
		}
		
		public static PlayerModel[] GetPlayerModels(){
			PlayerModel[] retval = {
				new PlayerModel("Dragonfly","DragonFlyVirus/DragonFly"),
				
			};
			return retval;
		}
	}
}

