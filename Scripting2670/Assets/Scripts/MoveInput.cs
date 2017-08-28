using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInput : MonoBehaviour {

    public static Action<float> KeyAction;

	// Update is called once per frame
	void Update () {
        if  (KeyAction !=null)
        {
            KeyAction(Input.GetAxis("Horizontal"));
        }
	}
}
