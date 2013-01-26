using UnityEngine;
using System.Collections;

public class ReplaceWBCs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//	Important note: The WBC prefab must be in the Assets/Resources folder. 
		
		GameObject[] objs = GameObject.FindGameObjectsWithTag("WBC");
		for(int i=0; i<objs.Length; ++i){
			GameObject wbcx = objs[i];
			GameObject parent = wbcx.transform.parent.gameObject;
			
			GameObject wbc = (GameObject)Instantiate(Resources.Load("WBC"));
			wbc.transform.parent = parent.transform;
//			wbc.transform.localPosition = wbcx.transform.localPosition;
//			wbc.transform.localRotation = wbcx.transform.localRotation;
//			wbc.transform.localScale = wbcx.transform.localScale;
			
			wbc.transform.position = wbcx.transform.position;
			wbc.transform.rotation = wbcx.transform.rotation;
			//wbc.transform.scale = wbcx.transform.scale;
			
			Destroy(wbcx);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
