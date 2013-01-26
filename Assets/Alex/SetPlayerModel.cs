using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class SetPlayerModel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GlobalData.ActivePlayerModel.resourceName;
		GameObject obj = (GameObject)Instantiate(Resources.Load ());
		obj.transform.parent = this.transform;
		obj.transform.position = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
