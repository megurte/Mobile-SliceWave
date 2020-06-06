using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjects : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Translate(-Vector3.up * Time.deltaTime *speed,Space.Self);
    }
    
}
