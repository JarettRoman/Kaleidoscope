using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    // Start is called before the first frame update

    Renderer sphereRenderer;
    void Start()
    {
        sphereRenderer = GetComponent<Renderer>();
        angle = Random.Range(60, 120f);
    }

    // Update is called once per frame
    void Update()
    {
        Spin();
        ChangeColor();
    }

    public override void Spin()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, angle * Time.deltaTime);
    }

    //Example of polymorphism. Sphere.cs has ChangeColor(), which is not in the Shape.cs parent class.
    public void ChangeColor()
    {
        sphereRenderer.material.SetColor("_Color", Color.Lerp(Color.green, Color.blue, Mathf.PingPong(Time.time, 1)));
    }

    
}
