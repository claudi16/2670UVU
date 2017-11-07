using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
	void Start () {
		PauseGame.pauseMenu += pauseMenuHandler;
		gameObject.SetActive(false);
	}
	void pauseMenuHandler(){
			gameObject.SetActive(true);
	}
}
