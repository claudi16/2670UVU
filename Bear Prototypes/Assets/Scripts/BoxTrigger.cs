using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour {

	public GameObject trigger;
	public GameObject triggered;
	public float x;
	public float y;
	public float z;


	public void OnTriggerEnter(Collider box){
		if(box.gameObject.tag == "Box"){
		triggered.transform.Rotate(x,y,z);
		}
	}
	public void OnTriggerExit(Collider box){
		if(box.gameObject.tag =="Box"){
		triggered.transform.Rotate(x,y,-z);
		}
	}

}
