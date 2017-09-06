using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour {

	public GameObject Lever;
	public GameObject Lever2;
	public GameObject Tree;
	public Rigidbody rb;

	void Start(){
		Lever = GameObject.FindGameObjectWithTag("Lever");
		Lever2 = GameObject.Find("Lever2");
		/*Tree = GameObject.Find("Tree");
		rb = Tree.GetComponent<Rigidbody>();*/
	}

	public void OnTriggerEnter(Collider Box){
		if (Box.name == "Box"){
		Lever.transform.Rotate(0,0,90);
		}
		if(Box.name == "Box2"){
		Lever2.transform.Rotate(0,0,90);
		}
		/*if(Tree.name == "Tree"){
			rb.isKinematic = true;
		}*/
	}
	public void OnTriggerExit(Collider Box){
		if(Box.name == "Box"){
		Lever.transform.Rotate(0,0,-90);
		}
		if(Box.name == "Box2"){;
		Lever2.transform.Rotate(0,0,-90);
		}
	}

}
