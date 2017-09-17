using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour {
	private GameObject pp;

    void Start(){
		pp = GameObject.Find("PlatformParent");
		pp.gameObject.SetActive(false);
   				 }
 	void OnTriggerEnter(Collider box){
		if(box.gameObject.tag == "Box"){
        foreach(Transform child in pp.transform){
			pp.gameObject.SetActive(true);
				}
			 }	 
   		 }
	void OnTriggerExit(Collider box){
		if(box.gameObject.tag == "Box"){
		pp.gameObject.SetActive(false);
		}
	}
//CHANGE IT SO IT STILL ONLY ACTIVATES VIA BOX
}
