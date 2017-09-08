using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	CharacterController cc;
	Vector3 tempMove;

	public float speed = 4;
	public float gravity = 1;
	public float jumpHeight = 0.3f;
	private int jumpScore = 0;
	private int maxJump = 1;

	// Use this for initialization
	void Start () 
	{
		cc = GetComponent<CharacterController>();
				PlayerInput.KeyAction += Move;
				PlayerInput.JumpAction = Jump;
	}

	void Move (float _movement) 
		{
		tempMove.y -= gravity*Time.deltaTime;
		tempMove.x = _movement*speed*Time.deltaTime;
		if (cc.isGrounded){
			jumpScore = 0;
		}
		cc.Move(tempMove);	
	}

	void Jump()
	{
		if(jumpScore < 1){
			tempMove.y = jumpHeight;
			jumpScore++;
		}
	}


	
}
