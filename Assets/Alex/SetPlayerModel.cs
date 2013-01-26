using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class SetPlayerModel : MonoBehaviour {
	
	public float turnSpeed = 0.1f;
	public float damping = 0.0f;
	
	// Use this for initialization
	void Start () {
		string resName = GlobalData.ActivePlayerModel.resourceName;
				Debug.Log (resName);
		GameObject obj = (GameObject)Instantiate(Resources.Load (resName));
		obj.transform.parent = this.transform;
		obj.transform.localPosition = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		updateFacing();
		
	}
	
	void updateFacing(){
		Vector3 moveDirection = this.transform.rigidbody.velocity;
		if(moveDirection.x == 0 && moveDirection.z == 0){
			return;
		}
		
		float angle;
		if(moveDirection.z == 0){
			angle = 0;
		} else if(moveDirection.x == 0) {
			if(moveDirection.z < 0){
				angle = Mathf.PI * 0.5f;
			} else {
				angle = -Mathf.PI * 0.5f;
			}
		} else {
			angle = Mathf.Atan (-moveDirection.z / moveDirection.x);
		}
		if(moveDirection.x < 0){
			
//			angle = Mathf.PI - angle;
			angle += Mathf.PI;
		}
		angle += Mathf.PI * 0.5f;
		if(angle < 0f){
			angle += Mathf.PI * 2f;
		}
		
		Vector3 garbage;
		float facing;
		this.transform.rotation.ToAngleAxis(out facing, out garbage);
		facing *= Mathf.PI / 180f;
		
		float difference = angle - facing;
		while(difference >= Mathf.PI){
			difference -= Mathf.PI * 2f;
		} 
		while(difference <= -Mathf.PI){
			difference += Mathf.PI * 2f;
		}
		
		Debug.Log ("angle: " + angle + "  facing: " + facing + "  difference: " + difference);
		//this.transform.rigidbody.AddTorque (new Vector3(0f, difference * turnSpeed,0f) - damping * this.transform.rigidbody.angularVelocity);
		
		this.transform.rotation = Quaternion.AngleAxis((angle + turnSpeed * difference) * 180f / Mathf.PI, Vector3.up);
		this.transform.rigidbody.angularVelocity *= 0f;
	}
}
