using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour {

	public GameObject trigger;
	public GameObject triggered;
	public float z;

	public void OnTriggerEnter(){
		triggered.transform.Rotate(0,0,z);
	}
	public void OnTriggerExit(){
		triggered.transform.Rotate(0,0,-z);
	}
}
