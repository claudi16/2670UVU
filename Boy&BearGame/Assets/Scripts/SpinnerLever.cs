using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerLever : MonoBehaviour {
	public GameObject spin1;
	public GameObject spin2;
	public GameObject spin3;
	public GameObject elevator;
	void Start(){
		SpinnerPuzzle.spinAction += spinActionHandler;
	}
	void spinActionHandler(){
	if(spin1.activeInHierarchy == true && spin2.activeInHierarchy == true && spin3.activeInHierarchy == true){
		elevator.SetActive(true);
		elevator.GetComponent<Elevator>().Start();
		}else{
			elevator.SetActive(false);
		}
	}
}
