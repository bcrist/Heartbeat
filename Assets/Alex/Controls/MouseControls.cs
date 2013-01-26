using UnityEngine;
using System.Collections;

public class MouseControls : MonoBehaviour {
	
	float velocity = 10f; //	Divide by 1000 for actual percentage
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Plane plane = new Plane(new Vector3(0f,1f,0f),Vector3.zero);
		float distance;
		plane.Raycast(ray, out distance);
		Vector3 point = ray.GetPoint (distance);
		
		this.transform.rigidbody.velocity += (point - this.transform.position) * velocity / 1000f;
		
		
	}
}
