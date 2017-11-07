using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PickUpCounter : MonoBehaviour {
	public static Action berryCountAct;
	void OnTriggerEnter(){
		SVars.berryCount++;
		berryCountAct();
		gameObject.SetActive(false);
	}
}
