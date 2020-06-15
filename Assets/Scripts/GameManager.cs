using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public float PointCount = 0;
    public Text TextCount;
    public GameObject TouchSlicer;

    private float speed = 10f;
    private Vector2 startPos;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        TextCount.text = PointCount.ToString();

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hitcol;


            TouchSlicer.SetActive(true);
            Vector2 touchposition = Camera.main.ScreenToViewportPoint(touch.position);
            TouchSlicer.transform.position = touchposition;
            //TouchSlicer.transform.position = Vector2.Lerp(TouchSlicer.transform.position, pos, Time.deltaTime * speed);

            
            //Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            //TouchSlicer.transform.position = touchPosition * speed;


            if (Physics.Raycast(ray, out hitcol))
            {
                if (hitcol.collider.CompareTag("GameCube"))
                    hitcol.collider.gameObject.GetComponent<BlockBroke>().BoxDestroy();

                if (hitcol.collider.CompareTag("RedGameCube"))
                    hitcol.collider.gameObject.GetComponent<RedBlockBroke>().RedBoxDestroy();

                if (hitcol.collider.CompareTag("RedGameCubeClassic"))               
                    hitcol.collider.gameObject.GetComponent<ClassicModeRedBlock>().RedBoxDestroyClassicMode();
            }

        }
        else
        {
            TouchSlicer.SetActive(false);

        }
    }


    //textcode
    void Swipe()
    {
        Vector2 delta = Input.GetTouch(0).deltaPosition;
        
        //horizontal
        if(Mathf.Abs(delta.x)> Mathf.Abs(delta.y))
        {
            //x+
            if (delta.x > 0)
            {
                
            }

            else
            {

            }
        }
        //vertical
        else
        {
            if (delta.y > 0)
            {

            }
            else
            {

            }

        }
    }
}
