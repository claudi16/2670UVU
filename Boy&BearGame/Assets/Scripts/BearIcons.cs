using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class BearIcons : MonoBehaviour {

	public Sprite[] BearItems;
	public SpriteRenderer BearItemsTracker;

	void Start(){
		PickUp.BearItem += BearItemHandler;		
	}
	void BearItemHandler(){			
		BearItemsTracker.sprite = BearItems[PickUp.pickupCount];		
		if(PickUp.pickupCount >=3){
		BearItemsTracker.sprite = BearItems[3];
		}
	}
}