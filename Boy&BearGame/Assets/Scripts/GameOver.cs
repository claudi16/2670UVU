using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameOver : MonoBehaviour {
	public static Action resetAll;
	void Start(){
		HealthHearts.ResetGame += ResetGameHandler;
	}
	public void ResetGameHandler(){
		resetAll();
	}
}
