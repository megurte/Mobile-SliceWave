using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObjects : MonoBehaviour
{
    Quaternion originRot;
    public float angle;

    private void Start()
    {
        angle = Random.Range(0, 360);
        originRot = transform.rotation;
    }

    void FixedUpdate()
    {
        angle++;
        Quaternion rotY = Quaternion.AngleAxis(angle, Vector3.up);
        Quaternion rotX = Quaternion.AngleAxis(angle, Vector3.right);
        transform.rotation = originRot * rotY *rotX;
    }
}
