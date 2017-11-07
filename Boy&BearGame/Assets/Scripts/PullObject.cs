using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullObject : MonoBehaviour {
	void Start(){
		MoveObject.Pull += PullHandler;
		}
	void PullHandler(){
		gameObject.transform.parent = null;
	}
}
