using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveObject : MonoBehaviour {
	public static Action Pull;

	void OnControllerColliderHit(ControllerColliderHit hit){
		Rigidbody body = hit.collider.attachedRigidbody;
		if(Input.GetKey(KeyCode.C) && hit.gameObject.tag == "Box"){
			SVars.jumpHeight = 0;
			body.transform.parent = gameObject.transform;
			}
		if(Input.GetKeyUp(KeyCode.C) || Input.GetKeyDown(KeyCode.C)){
			Pull();
			SVars.jumpHeight = 0.2f;
		}
		/*if(body.transform.parent == gameObject.transform && Input.GetKeyUp(KeyCode.C)){
			Pull();
		}*/
		/*public float pushForce = 2f;

	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		Rigidbody body = hit.collider.attachedRigidbody;
		
		if (hit.moveDirection.y < -.3f)
			return;

		Vector3 pushDirection = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
		body.velocity = pushForce*pushDirection;*/	
		/*if(hit.gameObject.tag == "Tree"){
			GameObject.Find("Boy").GetComponent<CharacterController>().enabled = false;
			Invoke("Unfreeze", 2.3f);
		}
	}
	void Unfreeze(){
		GameObject.Find("Boy").GetComponent<CharacterController>().enabled = true;
	}*/
}}


