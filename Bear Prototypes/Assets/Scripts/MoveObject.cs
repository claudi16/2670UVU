using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

		public float pushForce = 2f;

	void OnControllerColliderHit(ControllerColliderHit hit)
	{

		Rigidbody body = hit.collider.attachedRigidbody;

		if(body == null || body.isKinematic)
			return;
		
		if (hit.moveDirection.y < -.3f)
			return;

		Vector3 pushDirection = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.y);
		body.velocity = pushForce*pushDirection;
	}
}
