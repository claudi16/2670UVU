using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indy : MonoBehaviour {

	public GameObject indy;

	void OnTriggerEnter(Collider bush){
		if(bush.gameObject.tag == "ResetFall"){
			bush.gameObject.SetActive(false);
		}
	}
	void OnCollisionEnter(Collision platform)
	{
		if(platform.collider.tag == "PlatformResetFall"){
		indy.SetActive(false);
		}
	}
}
