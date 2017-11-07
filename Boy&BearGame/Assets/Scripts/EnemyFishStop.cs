using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFishStop : MonoBehaviour {

	void OnTriggerEnter(Collider big){
		big.transform.position = transform.position;
	}
}
