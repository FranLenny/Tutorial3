using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 tumble;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();

        rb.angularVelocity = Random.insideUnitSphere + tumble;
    }
}
