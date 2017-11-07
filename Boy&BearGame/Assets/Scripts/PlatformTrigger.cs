using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour {
	private GameObject pp;

    void Start(){
		pp = GameObject.Find("PlatformParent");
		pp.gameObject.SetActive(false);
   				 }
 	void OnTriggerEnter(){
        foreach(Transform child in pp.transform){
			pp.gameObject.SetActive(true);
			 }	 
   		 }
	void OnTriggerExit(){
		pp.gameObject.SetActive(false);
	}
//CHANGE IT SO IT STILL ONLY ACTIVATES VIA BOX
}
