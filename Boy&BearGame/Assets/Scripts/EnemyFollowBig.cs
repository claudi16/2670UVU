using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowBig : MonoBehaviour {

	public float speed = 2;
	public float gravity;
	float distance = 30;
	Transform player;
	bool follow = true;

	void Start(){
		player = GameObject.FindWithTag("Player").transform;
		WaterAction.EnemyChase += ChaseHandler;
		//StartCoroutine(follow());
	}
	void ChaseHandler() {
	
		if(Vector3.Distance(player.position, transform.position) <= distance && follow == true){
			transform.LookAt(player);			
			speed = 4;
			transform.position += transform.forward*speed*Time.deltaTime;
		}	
	}
	void OnTriggerEnter(Collider big){
		if(big.gameObject.tag == "BigStop"){
		follow = false;
		transform.position = big.transform.position;
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
