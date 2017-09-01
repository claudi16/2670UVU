using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	CharacterController cc;

	Vector3 tempMove;

	public float speed = 5;
	public float gravity = 1;
    public float jumpHeight = 0.2f;

    // Use this for initialization
    void Start () {
		cc = GetComponent<CharacterController>();

			PlayButton.Play += OnPlay;
	}
	void OnPlay() {
		MoveInput.JumpAction = Jump;
		MoveInput.KeyAction += Move;
		PlayButton.Play -= OnPlay;
	}
	void Jump (){
		print("Jump");
		tempMove.y += jumpHeight;
		//if jump count =2 reset jump count.
		//if grounded = true ******Create int, add number to int everytime space is hit, fire off function until certain number is reached.
	}

	// Update is called once per frame
	void Move (float _movement) {
		tempMove.y -= gravity*Time.deltaTime;
		tempMove.x = _movement*speed*Time.deltaTime;
		cc.Move(tempMove);
	}
}

//USE A COUNT FOR A DOUBLE JUMP
