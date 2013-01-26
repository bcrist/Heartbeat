using UnityEngine;
using System.Collections;

public class WBC_Collision_Handler : MonoBehaviour {

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
			Debug.Log ("Player is Dead");
	}
}
