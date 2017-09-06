using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeTrigger : MonoBehaviour {

	public GameObject Tree;
	private Rigidbody rb;

	void Start(){
		Tree = GameObject.Find("Tree");
		rb = Tree.GetComponent<Rigidbody>();
	}

	public void OnTriggerEnter(Collider Tree){
		if(Tree.name == "Tree"){
			rb.isKinematic = true;
		}
	}
}
