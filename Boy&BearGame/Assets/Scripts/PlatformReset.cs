using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformReset : MonoBehaviour {

	//place setting for the platforms to "respawn"
	public GameObject resetPoint;
	bool useGravity;
	public GameObject platformNum;

	void OnTriggerEnter(Collider touch)
	{
		if(touch.gameObject.tag == "PlatformResetFall"){
		platformNum.GetComponent<Rigidbody>().useGravity = false;	
		platformNum.GetComponent<Rigidbody>().isKinematic = true;	
		platformNum.transform.position = resetPoint.transform.position;
		platformNum.SetActive(false);
		Invoke("PlatformKin", 2f);
		}
	}
		void PlatformKin(){
		platformNum.SetActive(true);
		platformNum.GetComponent<Rigidbody>().isKinematic = false;
	}
}
