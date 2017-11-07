using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBlink : MonoBehaviour {
	public Renderer render;
	void Start(){
		render.enabled = true;
		HealthHarm.Blink += BlinkHandler;
	}
	void BlinkHandler(){
		StartCoroutine(Blinking());
	}

	IEnumerator Blinking(){
		while(SVars.blinks<10){
			render.enabled = !render.enabled;			
			SVars.blinks++;
			yield return new WaitForSeconds(0.04f);
		}
		render.enabled = true;
	}
}
