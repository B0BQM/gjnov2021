using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public PlayerControls controls;

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag=="Death"){
            controls.enabled = false;
        }
    }
}
