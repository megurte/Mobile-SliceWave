using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjects : MonoBehaviour
{

    public float speed;

    void FixedUpdate()
    {

        transform.Translate(-Vector3.up * Time.deltaTime *speed,Space.Self);
    }
    
}
