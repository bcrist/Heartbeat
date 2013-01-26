using UnityEngine;
using System.Collections;

public class ObjectRotator : MonoBehaviour {
	
	public float speed;
	
	void FixedUpdate()
	{
		transform.Rotate(new Vector3(0f,1f,0f), speed);
	}
	
}
