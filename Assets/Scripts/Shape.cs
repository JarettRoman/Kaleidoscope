using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    //Example of encapsulation. We set a default float of 20 degrees that can be overridden
    //only in classes inheriting Shape.
    //This also doubles as an example of inheritance since we're
    protected float angle = 20;
    public virtual void Spin()
    {
        transform.RotateAround(Vector3.zero, Vector3.back, angle * Time.deltaTime);
    }
}
