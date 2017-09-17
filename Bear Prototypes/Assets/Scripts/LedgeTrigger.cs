using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeTrigger : MonoBehaviour {

	public GameObject fallen;
	public GameObject trigger;

	public void OnTriggerEnter(Collider fallenobj){
		if(fallenobj.gameObject.tag == "Fallen"){
		fallen.GetComponent<Rigidbody>().isKinematic = true;
		fallen.GetComponent<Rigidbody>().useGravity = false;
		trigger.SetActive(false);
		}
	}
}
