using UnityEngine;
using System.Collections;

public class PlayerCollisionHandler : MonoBehaviour {
	
	
	void OnCollisionEnter (Collision collision)
	{
    	if (collision.gameObject.tag == "WBC")
			Debug.Log ("Player is Dead");
		
		else if (collision.gameObject.tag == "RBC")
			Debug.Log ("Red Blood Cell is Dead");
	}
}
