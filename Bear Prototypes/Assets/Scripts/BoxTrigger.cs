using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour {

	public GameObject Lever;
	void Start(){
		Lever = GameObject.FindGameObjectWithTag("Lever");
		Lever.GetComponent<RotateLever>().enabled = false;
	}

	public void OnTriggerEnter(Collider Box){
		if (Box.name == "Box"){
		print("Enter");
		Lever.transform.Rotate(0,0,90);
		}

	}
	public void OnTriggerExit(Collider Box){
		if(Box.name == "Box"){
		print("Exit");
		Lever.transform.Rotate(0,0,-90);
		}
	}
	
}
