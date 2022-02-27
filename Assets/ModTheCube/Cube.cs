using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float speed = 3.0f;
    
    void Start()
    {
        transform.position = new Vector3(0, 4, 0);
        transform.localScale = Vector3.one * 5.0f;
        
        Material material = Renderer.material;

        material.color = new Color32(12, 132, 120, 245);
    }
    
    void Update()
    {
        transform.Rotate(Time.deltaTime * speed * -25.0f, 0.0f, Time.deltaTime * speed * -25.0f);
    }
}
