using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLeft : MonoBehaviour
{
    public float speed = 0.7f;
    void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
