using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

	public void QuitButton(){
		print("Application has Quit");
		Application.Quit();
	}
}
