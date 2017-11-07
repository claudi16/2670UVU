using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterKnockback : MonoBehaviour {
	//CharacterController cc;

	void Start(){
		HealthHarm.KnockBack += KnockMove;
	}
	void KnockMove(){
		transform.position += transform.right *-1 * 2* SVars.speed* Time.deltaTime;
		transform.position += transform.up* 40* SVars.speed*Time.deltaTime;
	}

	/*void Start () {
		//cc = GetComponent<CharacterController>();
		HealthHarm.KnockBack += KnockMove;	
	}
	void KnockMove(){
		StartCoroutine(CharacterFallback());
	}
	IEnumerator CharacterFallback(){
		float timer = 0;
		while(timer < 2){
			timer++;
			//cc.Move(tempMove);
			tempMove.y -= SVars.gravity*Time.deltaTime;
			tempMove.y += 40*Time.deltaTime;
			transform.Translate(tempMove);
		}

		yield return 0.5f;
	}*/
}