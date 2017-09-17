using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCheckpoint : MonoBehaviour {

	public GameObject checkpoint;
	GameObject player;

	void Start(){
		player = GameObject.FindWithTag("Player");
	}

	void OnTriggerEnter(Collider player)
	{	if(player.gameObject.tag == "Player"){
		player.gameObject.SetActive(false);		
		player.gameObject.transform.position = checkpoint.transform.position;
		Invoke("Restart", 3);
		}

}
	void Restart(){
		player.gameObject.SetActive(true);
		player.transform.position = checkpoint.transform.position;	
	}
}