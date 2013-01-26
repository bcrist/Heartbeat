using UnityEngine;
using System.Collections;

public class IsRedBloodDeadBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision collision)
	{
    	//collision code
		
		if (collision.gameObject.tag == "Player" )
			Debug.Log ("One Red Cell Died");
	}
}
