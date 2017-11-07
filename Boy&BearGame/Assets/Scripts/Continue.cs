using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour {
	public void continueGame(){
		GameObject.FindWithTag("PauseMenu").SetActive(false);
		SVars.jump = true;
		Time.timeScale = 1;
	}
}
