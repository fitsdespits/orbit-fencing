using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLunge : MonoBehaviour
{
    //PLAYER
    public Rigidbody rb;
    
    //LOCK-ON
    public GameObject target;
    private bool lockedOn = true;

    //ATTACKING
    private bool attacking = false;

    void Update()
    {
        //LOCK-ON PLAYER ROTATION
        target = GameObject.FindGameObjectWithTag("LockedOn");
        Quaternion currentRotation = transform.rotation;
        Quaternion wantedRotation = Quaternion.LookRotation(target.transform.position);
        if (!attacking)
        {
            transform.rotation = Quaternion.RotateTowards(currentRotation, wantedRotation, Time.deltaTime * 300);
        }

        //ATTACK
        if (Input.GetKeyDown("space") && !attacking && lockedOn){
            attacking = true;
            Debug.Log("Attackin!");
            rb.AddForce(transform.forward * 1000 * Time.deltaTime);
            attacking = false;
            Debug.Log("-");
        }
    }
}
