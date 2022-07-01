using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        transform.Translate(
            Input.GetAxis("Horizontal") * Time.deltaTime * 10,
            0,
            Input.GetAxis("Vertical") * Time.deltaTime * 10
        );
    }
}
