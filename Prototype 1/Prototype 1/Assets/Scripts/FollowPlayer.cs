using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 5, -7);

    void FixedUpdate()
    {
        transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + offset;
    }
}
