using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Sphere
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spin();
    }

    public override void Spin()
    {
        transform.Rotate(Vector3.left, 120 * Time.deltaTime);
        base.Spin();
    }
}
