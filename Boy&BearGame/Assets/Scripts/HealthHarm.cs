using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthHarm : MonoBehaviour {
	public static Action Hurt;
	public static Action KnockBack;
	public static Action Blink;
	GameObject objHarm;
	public static bool harmOnce;

	void OnControllerColliderHit(ControllerColliderHit hit){
		if(hit.gameObject.tag == "Indy"){
		Hurt();
		}
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "ResetFall" || other.gameObject.tag == "Enemy"){
		gameObject.layer = 17;			
		harmOnce = true;
		SVars.blinks = 0;
		Hurt();
		KnockBack();
		Blink();
		Invoke("BlinkEnd", 2);
		}
	}
	void OnTriggerExit(){
		harmOnce = false;
	}
	void BlinkEnd(){
		gameObject.layer = 8;
	}
}
