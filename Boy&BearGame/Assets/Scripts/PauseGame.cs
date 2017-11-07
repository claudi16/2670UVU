using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PauseGame : MonoBehaviour {
	public static Action pauseMenu;
	public void Pause(){
		SVars.jump = false;
		pauseMenu();
	 	Time.timeScale = 0;
	}
}
