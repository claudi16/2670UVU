using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseStart : MonoBehaviour {
	public void CloseSplash(){
	GameObject.Find("StartScreen").SetActive(false);
	}
}
