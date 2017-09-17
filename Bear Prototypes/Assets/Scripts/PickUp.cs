using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
	public GameObject item;
	public GameObject newArea;

	void Start(){
		newArea.SetActive(false);
	}
	void OnTriggerEnter(Collider player)
	{
		if(player.gameObject.tag == "Player"){
		newArea.gameObject.SetActive(true);
		item.gameObject.SetActive(false);
		}
	}
}
