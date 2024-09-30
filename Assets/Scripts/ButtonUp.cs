using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUp : MonoBehaviour
{

    public Rigidbody rb;
    public float upForce = 500f;


    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ground")
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        };
    }


}
