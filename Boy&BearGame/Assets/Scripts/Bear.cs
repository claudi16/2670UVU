using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bear : MonoBehaviour {
	//public static Action End;

	void OnTriggerEnter()	{ 
		if(PickUp.pickupCount <=2){
			//End();
		}
		if(PickUp.pickupCount == 3){
			print("You may pass");
		}
	}
}
