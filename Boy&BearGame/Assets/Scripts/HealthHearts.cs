using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class HealthHearts : MonoBehaviour {

	public Sprite[] HeartSprites;
	public Image HeartSpritesTracker;
	public static Action ResetGame;

	void Start(){
		ResetAll.resetHealth += resetHealthHandler;
		HealthHarm.Hurt += HurtHandler;		
	}
	void HurtHandler(){
		if(HealthHarm.harmOnce == true){
		SVars.healthCounter++;
		HealthHarm.harmOnce = false;			
		}
		HeartSpritesTracker.sprite = HeartSprites[SVars.healthCounter];		
		if(SVars.healthCounter >=3){
		SVars.inWater = false;
		SVars.healthCounter = 0;
		HeartSpritesTracker.sprite = HeartSprites[0];
			ResetGame();
		}
	}
	void resetHealthHandler(){
		if(SVars.healthCounter ==0){
		HeartSpritesTracker.sprite = HeartSprites[0];		
		}
	}
}
