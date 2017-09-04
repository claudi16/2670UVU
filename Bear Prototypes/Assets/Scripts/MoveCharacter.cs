using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	CharacterController cc;
	Vector3 tempMove;

	public float speed = 4;
	public float gravity = 1;
	public float jumpHeight = 0.15f;
	public int jumpScore = 0;

	// Use this for initialization
	void Start () 
	{
		cc = GetComponent<CharacterController>();
				PlayerInput.KeyAction += Move;
				PlayerInput.JumpAction = Jump;
	}

	void Jump()
	{
		tempMove.y = jumpHeight;
		jumpScore++;
		if (cc.isGrounded){
			jumpHeight = 0.15f;
			jumpScore = 0;
			print(jumpScore);
		}
		if(jumpScore >=1){
			jumpHeight = 0;
		print(jumpScore);	
		}

	}

	void Move (float _movement) 
		{
		tempMove.y -= gravity*Time.deltaTime;
		tempMove.x = _movement*speed*Time.deltaTime;
		cc.Move(tempMove);	
	}
	
}
