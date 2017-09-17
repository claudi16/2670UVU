using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxReset : MonoBehaviour {

	public GameObject resetPoint;
	public GameObject boxNum;
	//public GameObject boxTag;

	void Start(){
		//boxTag = GameObject.FindWithTag("Box");
		EndGame.End += resetBox;
		//Physics.IgnoreCollision(boxTag.GetComponent<Collider>(), GetComponent<Collider>());
	}

	void OnTriggerEnter(Collider touch)
	{
		if(touch.gameObject.tag == "ResetFall" || touch.gameObject.tag == "BoxResetTouch"){	
		boxNum.transform.position = resetPoint.transform.position;
		boxNum.SetActive(false);
		Invoke("resetBox", 0.5f);
		}
	}
	void resetBox(){
		boxNum.SetActive(true);
		boxNum.transform.position = resetPoint.transform.position;
	}
}
