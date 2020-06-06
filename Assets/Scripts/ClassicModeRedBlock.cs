using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicModeRedBlock : RedBlockBroke
{
    [SerializeField]
    private GameObject gameover;

    [SerializeField]
    private GameObject Spawners;

    private void Start()
    {
        Spawners = GameObject.FindGameObjectWithTag("Spawners");
        gameover = GameObject.FindGameObjectWithTag("GameOver");
    }

    public void ClassicGameOver()
    {

        Debug.Log("Over");
        gameover.transform.Find("GameIsOver").gameObject.SetActive(true);
        Debug.Log(gameover.transform.Find("GameIsOver").gameObject.name);
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
