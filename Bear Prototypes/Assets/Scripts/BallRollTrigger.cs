using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRollTrigger : MonoBehaviour {

	public GameObject trigger;
	public GameObject triggered;
	public float x;
	public float y;
	public float z;


	public void OnTriggerEnter(Collider player){
		if(player.gameObject.tag == "Player"){
		triggered.transform.Rotate(x,y,z);
		}
	}

}
