using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    public float Currentexp = 0;
    private float Maxexp = 10;
    public int levelCount = 1;

    public Image Bar;
    public GameObject LevelUpWindow;
    //public float Fill;
    float Lerpspeed = 3.5f;

    void Start()
    {
        if (Level.lvl.currentexpStat > 0)
        {
            Currentexp = Level.lvl.currentexpStat;
        }
        if (Level.lvl.levelCountStat > 0)
        {
            levelCount = Level.lvl.levelCountStat;
        }
        if (Level.lvl.MaxexpStat > 3)
        {
            Maxexp = Level.lvl.MaxexpStat;
        }
        Debug.Log("Currentexp: "+Currentexp);
        Debug.Log("Currentexp Stat: " + Level.lvl.currentexpStat);

    }

    void Update()
    {
        gameObject.GetComponent<Text>().text = levelCount.ToString();
        GetExp();
        HandleBar();
    }


    void HandleBar()
    {
        if (Currentexp / 100 != Bar.fillAmount)
            Bar.fillAmount = Mathf.Lerp(Bar.fillAmount, Currentexp / 100, Time.deltaTime * Lerpspeed);
    }


    void GetExp()
    {
        
        if (Currentexp < Maxexp)
        {
            Currentexp += Level.lvl.exp;
            Level.lvl.currentexpStat = Currentexp;
            Level.lvl.exp = 0;
        }
        else
        {
            //Debug.Log("Passed");
            LevelUpWindow.SetActive(true);

            Level.lvl.exp = Currentexp - Maxexp;
            //max level
            Maxexp = Maxexp * 3;
            Level.lvl.MaxexpStat = Maxexp;

            levelCount += 1;
            Level.lvl.levelCountStat = levelCount;
        }
        
    }
}



class Level
{
    public static Level lvl = new Level();

    public float exp = 0;

    public float currentexpStat = 0;
    public float MaxexpStat = 3;
    public int levelCountStat = 0;
    

}
