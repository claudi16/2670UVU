using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IndyReset : MonoBehaviour {
	public GameObject checkpoint;
	public static Action ResetIndy;
	public static Action ResetBush;
	public static Action ResetBerry;
	public GameObject lever;

	void OnControllerColliderHit(ControllerColliderHit hit){
		if(hit.gameObject.tag == "Indy"){
		transform.position = checkpoint.transform.position;
		lever.transform.eulerAngles = new Vector3(0,0,0);
		ResetIndy();
		ResetBush();
		ResetBerry();
		gameObject.SetActive(false);
		Invoke("Restart", 2);
		}
}
	void Restart(){
		gameObject.SetActive(true);
		transform.position = checkpoint.transform.position;	
	}

}
