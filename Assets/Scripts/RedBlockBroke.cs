using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBlockBroke : BlockBroke
{
    public Color startcolor = new Vector4(1,1,1,0);

    MeshRenderer render;
    public GameObject gm;


    public void GetMinus()
    {
        gm = GameObject.FindGameObjectWithTag("GM");
        gm.GetComponent<GameManager>().PointCount -= 10;
    }

    //OnMouseOver
    public void RedBoxDestroy()
    {
        newpref.SetActive(true);
        Destroy(oldpref);
        Destroy(gameObject.GetComponent<BoxCollider>());
        GetMinus();
    }


    //private void OnMouseOver()
    //{
    //    newpref.SetActive(true);
    //    Destroy(oldpref);
    //    Destroy(gameObject.GetComponent<BoxCollider>());
    //    GetMinus();
    //}
}
