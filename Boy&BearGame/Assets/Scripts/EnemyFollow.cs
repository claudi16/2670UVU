using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public float speed = 2;
	public float gravity;
	float distance = 8;
	Transform player;
	public Transform startPosition;

	void Start(){
		player = GameObject.FindWithTag("Player").transform;
		WaterAction.EnemyChase += ChaseHandler;
		//StartCoroutine(follow());
	}
	void ChaseHandler() {
	
		if(Vector3.Distance(player.position, transform.position) <= distance){
			transform.LookAt(player);			
			speed = 2;
			transform.position += transform.forward*speed*Time.deltaTime;
		}
		if(Vector3.Distance(player.position, transform.position) >= distance){
			transform.LookAt(startPosition);
			speed = 5;
			transform.position += transform.forward*speed*Time.deltaTime;

		if(Vector3.Distance(transform.position, startPosition.position)<= 1){
			transform.position = startPosition.position;
			}
		}
	}

	/*IEnumerator follow(){
		while(Vector3.Distance(player.position, transform.position) <= distance){
			transform.LookAt(player);			
			speed = 2;
			print("min");
			print(distance);
			transform.position += transform.forward*speed*Time.deltaTime;
			yield return new WaitForSeconds(0.0f);
		}
		while(Vector3.Distance(player.position, transform.position) >= distance){
			transform.LookAt(startPosition);
			speed = 5;
			print("max");
			transform.position += transform.forward*speed*Time.deltaTime;
			yield return new WaitForSeconds(0.0f);
		}		
	}*/
}
