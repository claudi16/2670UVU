using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterMove : MonoBehaviour {
	CharacterController cc;
	Vector3 tempMove;
	void Start () 
	{
		cc = GetComponent<CharacterController>();
				CharacterInput.KeyAction += Move;
				CharacterInput.JumpAction = Jump;
	}
	void Move (float _movement) 
		{
		cc.Move(tempMove);	
		tempMove.y -= SVars.gravity*Time.deltaTime;
		tempMove.x = _movement*SVars.speed*Time.deltaTime;
		if (cc.isGrounded && SVars.inWater == false){
			tempMove.y = 0;
			SVars.jumpScore = 0;
		}
		if(SVars.inWater == true){
			SVars.jumpScore = 3;		
		}
		if(SVars.inWater == true && cc.isGrounded){
			tempMove.y = 0;
		}
	}
	void Jump(){
		if(SVars.jumpScore < 2){
			tempMove.y = SVars.jumpHeight;
			SVars.jumpScore++;
		}
		if(SVars.jumpScore >=3){
			tempMove.y = SVars.jumpHeight;
		}
	}	
}