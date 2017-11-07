using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterReset : MonoBehaviour {

	//public Transform startPoint;
	//public GameObject start;
	public Renderer render;
	Vector3 originalPosition;

	void Start(){
		HealthHearts.ResetGame += ResetThis;
		//Bear.End += ResetThis;
		originalPosition = gameObject.transform.position;
		//start = GameObject.Find("startPoint");
	}

	void ResetThis(){	
		gameObject.SetActive(false);
		transform.position = originalPosition;
		Invoke("Restart", 3);
	}

	void Restart(){
		gameObject.SetActive(true);
		//transform.position = start.transform.position;
		render.enabled = true;
	}
}
