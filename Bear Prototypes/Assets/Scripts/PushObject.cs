using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObject : MonoBehaviour {

	public float pushForce = 3f;
	public static bool fallen = false;

	void OnControllerColliderHit(ControllerColliderHit hit){
		if(hit.gameObject.tag == "Box"){
			print("ayy lmao");
		}
	/*	fallen = true;
		Rigidbody body = hit.collider.attachedRigidbody;

	if(body == null || body.isKinematic)
		return;
	if(hit.moveDirection.y < -0.3f)
		return;
	
	Vector3 pushDirection = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.y);
	body.velocity = pushForce*pushDirection;
	test();
	}
	
	//have boy freeze until tree has fallen over
	void test(){
	if(fallen == true){
	GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationZ;

		}*/
	}
}

