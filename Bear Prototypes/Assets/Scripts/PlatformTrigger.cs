using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour {
	private GameObject pp;

    void Start(){
		pp = GameObject.Find("PlatformParent");
		pp.gameObject.SetActive(false);

    }

 	void OnTriggerEnter(Collider other){
		if(other.name == "Boy"){
			print("poo");
        foreach(Transform child in pp.transform){
			pp.gameObject.SetActive(true);
			
		}
	 }	 
    }

}
