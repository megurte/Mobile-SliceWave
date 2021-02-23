using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameovertext;
    public GameObject Spawners;

    GameObject gamemanager;

    float Points;

    void Start()
    {
        gamemanager = GameObject.FindGameObjectWithTag("GM");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Over");
        //Points = gamemanager.GetComponent<GameManager>().PointCount;
        if (other.tag == "GameCube")
        {
            Debug.Log("Over");
            gameovertext.SetActive(true);
            Spawners.SetActive(false);

            //+exp
            Level.lvl.exp += Points + 20;

            if (ResultClass.Inst.ArcadeResult < Points)
                ResultClass.Inst.ArcadeResult = Points;

            //Destroy(gameObject.GetComponent<TimerArcadeScene>());
        }
       
    }
}
