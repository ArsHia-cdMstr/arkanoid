using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board_move : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        transform.position += new Vector3 (0f , 0f , -speed);
    }
}
