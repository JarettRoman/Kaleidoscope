using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        //This is an example of inheritance since we're defining float angle in Shape.cs, the parent class of Cube
        angle = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Spin();
    }

    //Example of Polymorphism - we override the Spin() function in Shape.cs. But we also call it as well with base.
    public override void Spin() {
        transform.Rotate(Vector3.left, angle * Time.deltaTime);
        base.Spin();
    }
}
