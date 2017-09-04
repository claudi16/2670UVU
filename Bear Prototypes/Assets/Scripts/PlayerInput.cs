using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerInput : MonoBehaviour {

	public static Action<float> KeyAction;
    public static Action JumpAction;

	void Update () {

        if  (KeyAction !=null)
        {
            KeyAction(Input.GetAxis("Horizontal"));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAction();
        
        }
                
    }
}
