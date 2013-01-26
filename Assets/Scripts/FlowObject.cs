using UnityEngine;
using System.Collections;

public class FlowObject : MonoBehaviour {
	
	public Vector3 flow_direction;
	
	private ArrayList objects_in_flow;
	private float last_flow_time;
	
	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Player")
			objects_in_flow.Add(collision.gameObject);
	}
	
	void onCollisionExit(Collision collision)
	{
		objects_in_flow.Remove(collision.gameObject);
	}
	
	
	void FixedUpdate () {
		if (Time.fixedTime - last_flow_time > 4f)
		{
			last_flow_time = Time.fixedTime;
			pushObjects();
		}
	}
	
	void pushObjects()
	{
		for (int i = 0; i < objects_in_flow.Count; ++i)
		{
			GameObject obj = (GameObject)objects_in_flow[i];
			
			Rigidbody rb = obj.GetComponent<Rigidbody>();
			
			rb.AddForce (flow_direction);
		}
	}
}
