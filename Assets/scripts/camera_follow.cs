using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour
{
    public Transform t;
    public Vector3 distance;

    private void FixedUpdate()
    {
        transform.position = t.position + distance;
    }
}
