using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slicer : MonoBehaviour
{
    private float speed = 10f;
    private Vector2 startPos;

    //void Update()
    //{
    //    if (Input.touchCount > 0)
    //    {
    //        var touch = Input.GetTouch(0);

    //        switch (touch.phase)
    //        {
    //            case TouchPhase.Began:
    //                startPos = touch.position;
    //                break;

    //            case TouchPhase.Moved:
    //                var dir = touch.position - startPos;
    //                var pos = transform.position + new Vector3(transform.position.x, transform.position.y, dir.y);
    //                transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * speed);
    //                break;
    //        }
    //    }
    //}
}
