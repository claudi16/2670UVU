using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BerryCounterText : MonoBehaviour {
	public Text counterText;
	int threeBerry = 3;
	void Start () {
	counterText.text = ("   x " + SVars.berryCount);	
	PickUpCounter.berryCountAct += berryCountActHandler;
	}
	void berryCountActHandler(){
	counterText.text = ("   x " + SVars.berryCount);
	}
}
