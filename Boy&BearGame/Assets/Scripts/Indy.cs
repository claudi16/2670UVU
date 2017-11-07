using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indy : MonoBehaviour {

	public GameObject indy;
	public GameObject startPoint;

	void Start(){
		IndyReset.ResetIndy += Reset;
	}
	void OnCollisionEnter(Collision other)
	{
		if(other.collider.tag == "PlatformResetFall"){
		indy.SetActive(false);
		}
	}
	void Reset(){
		gameObject.transform.position = startPoint.transform.position;
		gameObject.GetComponent<Rigidbody>().isKinematic = true;
	}
}
