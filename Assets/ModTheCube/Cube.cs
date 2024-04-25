using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float horizontalInput;
    private float verticalInput;
    public float speed = 45;
    
    void Start()
    {
        transform.position = new Vector3(0, 7, 2);
        transform.localScale = Vector3.one * 12f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.8f, 1.0f, 0.3f, 0.2f);
    }
    
    void Update()
    {
        transform.Rotate(90.0f * Time.deltaTime, 75.0f * Time.deltaTime, 80.0f * Time.deltaTime);

        //input player horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //input player vertical
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
