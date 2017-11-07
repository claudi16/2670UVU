using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTriggerColor : MonoBehaviour {
//Colored boxes aren't working fix it gurl
	public GameObject trigger;
	public GameObject boxCol;
	private static int boxTriggered = 0;
	public GameObject newArea;

	void Start(){
		//CHANGE TO FALSE
		newArea.SetActive(false);
	}
	public void OnTriggerEnter(Collider box){
		if(box.gameObject == boxCol){
		boxTriggered++;			
		}
		if(boxTriggered == 2){
		newArea.SetActive(true);
		}
	}
	public void OnTriggerExit(Collider box){
		if(box.gameObject == boxCol){
			boxTriggered--;
		}
	}
}
