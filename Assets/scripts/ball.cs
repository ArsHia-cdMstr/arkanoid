using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public Rigidbody rb;
    public float force;

    void Start()
    {
        rb.AddForce(0f ,0f ,-force * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        
    }
}
