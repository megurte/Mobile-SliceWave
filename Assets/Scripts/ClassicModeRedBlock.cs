using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicModeRedBlock : RedBlockBroke
{
    [SerializeField]
    private GameObject gameover;

    [SerializeField]
    private GameObject Spawners;

    float Points;

    private void Start()
    {
        Spawners = GameObject.FindGameObjectWithTag("Spawners");
        gameover = GameObject.FindGameObjectWithTag("GameOver");
        gm = GameObject.FindGameObjectWithTag("GM");
    }

    public void ClassicGameOver()
    {
        Points = gm.GetComponent<GameManager>().PointCount;

        Debug.Log("Over");
        gameover.transform.Find("GameIsOver").gameObject.SetActive(true);
        Debug.Log(gameover.transform.Find("GameIsOver").gameObject.name);
        
        
        //exp
        Level.lvl.exp += Points;

        if (ResultClass.Inst.ClassicResult < Points)
            ResultClass.Inst.ClassicResult = Points;

        Spawners.SetActive(false);
    }


    public void RedBoxDestroyClassicMode()
    {
        newpref.SetActive(true);
        Destroy(oldpref);
        Destroy(gameObject.GetComponent<BoxCollider>());
        ClassicGameOver();
    }
}
