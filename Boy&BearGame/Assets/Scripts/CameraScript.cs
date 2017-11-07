using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject Boy;
	private Vector3 offset;

	void Start () {
		Boy = GameObject.Find("Boy");
		offset = transform.position - Boy.transform.position;
	}
	void LateUpdate () {
		transform.position = Boy.transform.position + offset;
	}
}
