using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRollTrigger : MonoBehaviour {
	public GameObject trigger;
	public GameObject triggered;

	public void OnTriggerEnter(){
		triggered.transform.eulerAngles = new Vector3(0,0,-8);
		GameObject.Find("Indy").GetComponent<Rigidbody>().isKinematic = false;
	}
}
