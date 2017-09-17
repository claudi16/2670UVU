using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	CharacterController cc;
	Vector3 tempMove;

	public float speed = 4;
	public float gravity = 1f;
	public float jumpHeight = 0.3f;
	private int jumpScore = 0;
	public static bool swim = false;

	// Use this for initialization
	void Start () 
	{
		cc = GetComponent<CharacterController>();
				PlayerInput.KeyAction += Move;
				PlayerInput.JumpAction = Jump;
	}

	void Move (float _movement) 
		{
		tempMove.y -= gravity*0.7f*Time.deltaTime;
		tempMove.x = _movement*speed*Time.deltaTime;
		if (cc.isGrounded){
			jumpScore = 0;
		}
		
		cc.Move(tempMove);	

		if (swim == true){
		gravity = 0.4f;
		speed = 2;
		}
		if(swim == false){
		gravity = 1f;
		speed = 4;
		}
	}

	void Jump()
	{
		if(jumpScore < 1 && swim == false){
			jumpHeight = 0.3f;
			tempMove.y = jumpHeight;
			jumpScore++;
		}
		if(swim == true){
			jumpHeight = 0.15f;
			tempMove.y = jumpHeight;
		}
	}

	void OnTriggerEnter(Collider water)
	{
		if(water.gameObject.tag == "Water"){
			swim = true;
		}
	}
	void OnTriggerExit(Collider water){
		if(water.gameObject.tag == "Water"){
			swim = false;
		}
	}
}
