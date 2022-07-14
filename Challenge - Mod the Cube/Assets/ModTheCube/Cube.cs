using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(1.5f, 2.0f, 3.3f, 2.4f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 1.0f, 1.0f);
    }
}
