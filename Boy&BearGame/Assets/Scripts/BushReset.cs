using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushReset : MonoBehaviour {

	void Start(){
		IndyReset.ResetBush += Reset;		
	}
	void OnTriggerEnter(Collider other){
	if(other.gameObject.tag == "Indy"){
	gameObject.SetActive(false);
		}	
	}
	void Reset(){
		gameObject.SetActive(true);
	}
}
