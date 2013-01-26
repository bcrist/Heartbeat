using UnityEngine;
using System.Collections;

public class AirDrag : MonoBehaviour {
	
	float dragFactor = 97.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rigidbody.velocity *= dragFactor * 0.01f;
	}
}
