using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterInput : MonoBehaviour {

	public static Action<float> KeyAction;
    public static Action JumpAction;
    public static Action Dash;
	void Update () {

        if  (KeyAction !=null) {
            KeyAction(Input.GetAxis("Horizontal"));
        }
        if (Input.GetKeyDown(KeyCode.Space) && SVars.jump == true) {
            JumpAction();
        }   
        if(Input.GetKeyUp(KeyCode.C)){
            transform.DetachChildren();
            SVars.jumpHeight = 0.2f;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            Dash();
        }
    }
}