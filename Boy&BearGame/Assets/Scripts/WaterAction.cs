using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WaterAction : MonoBehaviour {
	public static Action TempVars;
	public static Action TempVarsOff;
	public static Action EnemyChase;

	void OnTriggerStay(){
		SVars.inWater = true;
		TempVars();
		EnemyChase();
	}
	void OnTriggerExit(){
		SVars.inWater = false;
		SVars.jumpScore = 0;
		TempVarsOff();
	}
}