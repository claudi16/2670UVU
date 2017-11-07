using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
	float dir = 1;
	public GameObject player;//Parent to the thing

	void Awake(){
		gameObject.SetActive(false);
	}
	public void Start(){
		StartCoroutine(Right());
	}
	IEnumerator Right(){
		while(dir ==1){
		gameObject.transform.position += transform.forward *2* Time.deltaTime;
		yield return new WaitForSeconds(0.01f);
		}
	}
	void OnTriggerEnter(){
		transform.rotation *= Quaternion.Euler(0,180,0);
	}
}
	/*Vector3 direction = Vector3.zero;
	void Awake(){
		gameObject.SetActive(false);		
	}
	public void Start(){
		if(ElevatorSwitch.eleSwitch == 1 ||ElevatorSwitch.eleSwitch == 3)	{
		StartCoroutine(ElevatorMoveUp());			
		}else{
		StartCoroutine(ElevatorMoveDown());
		}
		ElevatorSwitch.ElevatorUp += ElevatorUpHandler;
		ElevatorSwitch.ElevatorDown += ElevatorDownHandler;
	}
	void ElevatorUpHandler(){
		StartCoroutine(ElevatorMoveUp());	
	}
	void ElevatorDownHandler(){
		StartCoroutine(ElevatorMoveDown());
	}
	IEnumerator ElevatorMoveUp(){
		while(ElevatorSwitch.eleSwitch == 1 || ElevatorSwitch.eleSwitch == 3){
			transform.Translate(Vector3.up*2*Time.deltaTime, Space.World);
			yield return new WaitForSeconds(0.01f);
		}
	}
	IEnumerator ElevatorMoveDown(){
		while(ElevatorSwitch.eleSwitch == 2){
			transform.Translate(Vector3.down*2*Time.deltaTime, Space.World);
			yield return new WaitForSeconds(0.01f);
		}
}*/
