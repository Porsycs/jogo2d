using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    public float vel = 0.1f;
    public Renderer quad;
    void Start()
    {
        
    }

    void Update()
    {
        //transform.Rotate(new Vector3(0,0,0.5f)); Rotação
       //transform.Translate(new Vector3(0.1f, 0, 0)); Movimentação
       //transform.localScale += new Vector3(0.1f, 0.1f, 0); Zoom 
        Vector2 offset = new Vector2(vel * Time.deltaTime, 0);
        quad.material.mainTextureOffset+= offset;
    }
}
