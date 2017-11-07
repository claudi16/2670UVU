using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PickUp : MonoBehaviour {
	public static Action BearItem;
	public static int pickupCount = 0;
	public GameObject newArea;
	public GameObject itemHUD;

	void Start(){
		ResetAll.resetHUD += resetHUDHandler;
		itemHUD.gameObject.SetActive(false);
		newArea.SetActive(false);
	}
	void OnTriggerEnter(){
		itemHUD.SetActive(true);
		pickupCount++;
		BearItem();
		newArea.gameObject.SetActive(true);
		gameObject.SetActive(false);
	}
	void resetHUDHandler(){
		gameObject.SetActive(true);
		itemHUD.gameObject.SetActive(false);
		newArea.SetActive(false);
		pickupCount = 0;
	}
}
