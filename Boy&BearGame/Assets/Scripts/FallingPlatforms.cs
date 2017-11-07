using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatforms : MonoBehaviour {
	
	public bool useGravity;
	GameObject platform;

	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if(hit.gameObject.tag == "Platform"){
			platform = hit.gameObject;
			Invoke("Fall", 0.001f);
		}
	}
	void Fall(){
		platform.GetComponent<Rigidbody>().useGravity = true;
	}
}
