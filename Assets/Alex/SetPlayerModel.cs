using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class SetPlayerModel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string resName = GlobalData.ActivePlayerModel.resourceName;
				Debug.Log (resName);
		GameObject obj = (GameObject)Instantiate(Resources.Load (resName));
		obj.transform.localScale *= 50;
		obj.transform.parent = this.transform;
		obj.transform.localPosition = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
