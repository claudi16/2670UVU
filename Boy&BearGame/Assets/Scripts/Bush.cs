using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour {
	public GameObject checkpoint;
	void OnTriggerEnter(Collider Player){
		if(Player.gameObject.tag == "Player"){
			SVars.healthCounter++;
			Player.transform.position = checkpoint.transform.position;
		}
	}
}
