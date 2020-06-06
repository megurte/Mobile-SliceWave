using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBroke : MonoBehaviour
{
    public GameObject oldpref;
    public GameObject newpref;
    private GameObject gamemanager;

    // Update is called once per frame
    void Update()
    {
        ///somethig new. Touch testing
        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    Ray ray = Camera.main.ScreenPointToRay(touch.position);
        //    RaycastHit hit = new RaycastHit();

        //        if(Physics.Raycast(ray, out hit))
        //        {
        //            Debug.Log("hit");
        //            if (hit.collider.CompareTag("GameCube"))
        //            {
        //                BoxDestroy();
        //                Debug.Log("hit2");
        //            }
        //        }
        //}

    }


    //OnMouseOver
    public void BoxDestroy()
    {
        
        newpref.SetActive(true);

        Destroy(oldpref);
        Destroy(gameObject.GetComponent<BoxCollider>());
        
        gamemanager = GameObject.FindGameObjectWithTag("GM");
        gamemanager.GetComponent<GameManager>().PointCount += 1f;        
    }

    //private void OnMouseOver()
    //{
    //    newpref.SetActive(true);

    //    Destroy(oldpref);
    //    Destroy(gameObject.GetComponent<BoxCollider>());

    //    gamemanager = GameObject.FindGameObjectWithTag("GM");
    //    gamemanager.GetComponent<GameManager>().PointCount += 1f;
    //}
}
