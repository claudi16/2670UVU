using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClimb : MonoBehaviour {
	CharacterController cc;
	public GameObject Boy;
	bool canClimb = false;
	public float smoothFactor = 2;

	void Start(){
		cc = GetComponent<CharacterController>();
		Boy = GameObject.Find("Boy");
	}

	public void OnTriggerEnter(Collider Boy){
		if(Boy.name == "Boy"){
			canClimb = true;
		}
	}
	public void OnTriggerExit(Collider Boy){
		if(Boy.name == "Boy"){
			canClimb = false;
		}
	}
	void Update(){
		if(canClimb){
			if(Input.GetKey(KeyCode.UpArrow)){
				Boy.transform.position += Vector3.up / 3;
			}
		}
	}
	
}
