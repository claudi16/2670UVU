using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTriggerColor : MonoBehaviour {

	public GameObject trigger;
	public GameObject boxCol;
	int boxTriggered = 0;

	public void OnTriggerEnter(Collider box){
		if(box.gameObject.tag == "Box" && box.gameObject == boxCol){
		boxTriggered += 1;
		}
	}
	public void OnTriggerExit(Collider box){
		if(box.gameObject.tag =="Box" && box.gameObject == boxCol){
		boxTriggered -= 1;
//retract from score
		}
	}
//create a coroutine for when boxTriggered = 2;
}
