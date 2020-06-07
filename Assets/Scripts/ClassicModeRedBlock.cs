using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicModeRedBlock : RedBlockBroke
{
    [SerializeField]
    private GameObject gameover;

    [SerializeField]
    private GameObject Spawners;

    GameObject gamemanager;
    float Points;

    private void Start()
    {
        Spawners = GameObject.FindGameObjectWithTag("Spawners");
        gameover = GameObject.FindGameObjectWithTag("GameOver");
        gamemanager = GameObject.FindGameObjectWithTag("GM");
    }

    public void ClassicGameOver()
    {
        Points = gamemanager.GetComponent<GameManager>().PointCount;

        Debug.Log("Over");
        gameover.transform.Find("GameIsOver").gameObject.SetActive(true);
        Debug.Log(gameover.transform.Find("GameIsOver").gameObject.name);

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
