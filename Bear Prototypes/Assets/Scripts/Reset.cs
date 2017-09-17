using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {

	public Transform startPoint;
	public GameObject start;

	void Start(){
		EndGame.End += ResetThis;
		start = GameObject.Find("startPoint");
	}

	void ResetThis(){	
		gameObject.SetActive(false);
		transform.position = start.transform.position;
		Invoke("Restart", 3);
	}

	void Restart(){
		gameObject.SetActive(true);
		transform.position = start.transform.position;
	}
}
