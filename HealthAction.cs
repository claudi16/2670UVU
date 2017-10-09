using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendHealth : MonoBehaviour {
    public static Action<float> HealthAction;

    public float health = 1.0f;

    public static void UpdateHealth(float _power){
     health+= _power;
     if(health <0){
         health = 0;
     }
     if(health >1){
         health = 1;
     }

     HealthAction(health);
    }
}