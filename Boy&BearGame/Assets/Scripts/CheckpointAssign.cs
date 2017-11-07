using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointAssign : MonoBehaviour {

	public GameObject newCheckpoint;
	void OnTriggerEnter(){
	newCheckpoint.transform.position = transform.position;
	}
}
