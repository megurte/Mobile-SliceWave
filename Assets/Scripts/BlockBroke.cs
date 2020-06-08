using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBroke : MonoBehaviour
{
    public GameObject oldpref;
    public GameObject newpref;
    private GameObject gamemanager;

    public float Pointsamount;


    //OnMouseOver
    public void BoxDestroy()
    {
        
        newpref.SetActive(true);

        Destroy(oldpref);
        Destroy(gameObject.GetComponent<BoxCollider>());
        
        gamemanager = GameObject.FindGameObjectWithTag("GM");
        gamemanager.GetComponent<GameManager>().PointCount += Pointsamount;        
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
