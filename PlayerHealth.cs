using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHealthBar : MonoBehaviour {
    public float power = 0.1f;

    void Start(){
        SendHealth.HealthAction.UpdateHealth(power);
    }
    Vector3 scale = Vector3.one;

    private void ChangeHealthBar(float _health){
        scale.x = _health;
        transform.localScale = scale;
    }

}
                                                                