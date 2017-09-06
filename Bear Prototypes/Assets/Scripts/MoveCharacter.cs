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
		cc.Move(tempMove);	
	}

	void Jump()
	{
		tempMove.y = jumpHeight;
		jumpScore++;

		if (cc.isGrounded){
			jumpScore = 0;
			jumpHeight = 0.3f;
			print(jumpScore);
		}
		if(!cc.isGrounded && jumpScore < maxJump){
			jumpScore++;
		}
		if(!cc.isGrounded && jumpScore >= maxJump){
			jumpHeight = 0;
		}
		/*else{
			if (jumpScore <= maxJump){ 
					jumpScore++;
			}
			if (jumpScore >= maxJump){
					jumpHeight = 0;
			}
		}*/

	}


	
}
