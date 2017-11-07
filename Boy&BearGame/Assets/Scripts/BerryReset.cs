using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryReset : MonoBehaviour {

	public GameObject newArea;
	void Start(){
		IndyReset.ResetBush += Reset;	
	}	
	void Reset(){
		if(PickUp.pickupCount >= 0){
			PickUp.pickupCount --;}
		if(PickUp.pickupCount < 0){
			PickUp.pickupCount = 0;
		}
		print(PickUp.pickupCount);
		gameObject.SetActive(true);
		newArea.SetActive(false);
	}
}
