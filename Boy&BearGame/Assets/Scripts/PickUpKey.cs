using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour {
	void OnTriggerEnter(Collider player){
		if(player.gameObject.tag == "Player"){
		transform.parent = player.gameObject.transform;
		}
	}
}
