using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowLand : MonoBehaviour {
	float dir = 1;
	public float speed = 2;
	public GameObject player;

	void Start(){
		StartCoroutine(Right());
	}
	IEnumerator Right(){
		while(dir ==1){
		gameObject.transform.position += transform.forward *speed* Time.deltaTime;
		yield return new WaitForSeconds(0.01f);
		}
	}
	void OnTriggerEnter(){
		transform.rotation *= Quaternion.Euler(0,180,0);
	}
}
