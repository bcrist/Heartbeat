using UnityEngine;
using System.Collections;

public class LockCamera : MonoBehaviour {
	
	public Camera target;
	public Vector3 offset;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		target.transform.position = this.transform.position + offset;
	}
}
