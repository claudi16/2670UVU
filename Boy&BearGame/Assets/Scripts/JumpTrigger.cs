using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour {

	public static bool triggerEntered = false;
	private int jumpCount;
	public GameObject watPlat;
	public GameObject brokenBridge;

	void Start(){
		watPlat.gameObject.SetActive(false);
	}
	void OnTriggerStay(){
		triggerEntered = true;
		if(Input.GetKeyDown(KeyCode.Space)){
			jumpCount++;
		}
		if(jumpCount == 6 && triggerEntered == true){
			watPlat.gameObject.SetActive(true);
			brokenBridge.GetComponent<Rigidbody>().useGravity = true;
			brokenBridge.GetComponent<Rigidbody>().isKinematic = false;
			gameObject.SetActive(false);
		}
	}
	void OnTriggerExit(Collider player){
			triggerEntered = false;
	}
	/*void Update(){
		if(triggerEntered == true && Input.GetKeyDown(KeyCode.Space)){
		Invoke("JumpCounter", 1f);
		}
	}
	void JumpCounter(){
		jumpCount++;
		print(jumpCount);
		if(jumpCount == 2){
			watPlat.gameObject.SetActive(true);
			GameObject.Find("Bridge").SetActive(false);
			Invoke("DestroyFallen", 2);
		}
	}
	void DestroyFallen(){
		watPlat.gameObject.SetActive(false);
		gameObject.SetActive(false);
	}*/
}
