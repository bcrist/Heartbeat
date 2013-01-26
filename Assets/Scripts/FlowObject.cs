using UnityEngine;
using System.Collections;

public class FlowObject : MonoBehaviour {
	
	public Vector3 flow_vector;
	public float pulse_interval;
	
	private ArrayList objects_in_flow;
	private float last_flow_time;
	
	void Start()
	{
		objects_in_flow = new ArrayList();
		last_flow_time = 0;
	}
	
	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Player")
		{
			objects_in_flow.Add(col.gameObject);
		}
	}
	
	void OnTriggerExit(Collider col)
	{
		objects_in_flow.Remove(col.gameObject);
	}
	
	
	void FixedUpdate () {
		if (Time.fixedTime - last_flow_time > pulse_interval)
		{
			last_flow_time = Time.fixedTime;
			pushObjects();
		}
	}
	
	void pushObjects()
	{
		for (int i = 0; i < objects_in_flow.Count; ++i)
		{
			GameObject obj = objects_in_flow[i] as GameObject;
			Rigidbody rb = obj.GetComponent<Rigidbody>();
			rb.AddForce (flow_vector);
		}
	}
}
