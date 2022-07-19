using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    public Rigidbody rd;
    public float forward_force;
    public float sidway_force;
    
    private void FixedUpdate()
    {
        if (Input.GetKey("w"))
            rd.AddForce(0f, 0f, forward_force * Time.deltaTime);

        if (Input.GetKey("s"))
            rd.AddForce(0f, 0f, -forward_force * Time.deltaTime);

        if (Input.GetKey("d"))
            rd.AddForce(sidway_force * Time.deltaTime , 0f, 0f);

        if (Input.GetKey("a"))
            rd.AddForce(-sidway_force * Time.deltaTime, 0f, 0f);
    }
}
