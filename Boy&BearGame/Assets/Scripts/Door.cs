using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	public GameObject door;
	void OnTriggerEnter(Collider key){
		door.SetActive(false);
		if(key.gameObject.tag == "Box"){
			key.transform.parent = gameObject.transform;
			key.transform.localPosition = Vector3.zero;
			key.transform.localPosition = new Vector3(1,0,0);
		}
	}
}
