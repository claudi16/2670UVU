using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpinnerPuzzle : MonoBehaviour {
	public static Action spinAction;
	public GameObject spinActionObj;
	public GameObject spinner;
	bool spinnerCountTF;
	bool rotTF;
	//PUT IN SWITCHES!
		void Start(){
			spinActionObj.SetActive(false);
		}
		void OnTriggerStay(){
		 if (Input.GetKeyDown(KeyCode.C) && spinnerCountTF == true){
			 spinner.transform.rotation *= Quaternion.Euler(0,0,120);
			 rotTF = true;
			 spinnerCountTF = false;		 
		 }
		 if(Input.GetKeyUp(KeyCode.C)){
			 spinnerCountTF = true;
			 rotTF = false;
		 }
		if(spinner.transform.rotation.y == 1.0 && rotTF == true || spinner.transform.rotation.y == -1.0 && rotTF == true){
		spinActionObj.SetActive(true);
		spinAction();
		rotTF = false;
		}
		if(spinner.transform.rotation.y != 1.0 && rotTF == true || spinner.transform.rotation.y != -1.0 && rotTF == true){
		spinActionObj.SetActive(false);
		spinAction();
		rotTF = false;
		}		
	}
}
