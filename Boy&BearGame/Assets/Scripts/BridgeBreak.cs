using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeBreak : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		GameObject.Find("Bridge").SetActive(false);
	}
}
