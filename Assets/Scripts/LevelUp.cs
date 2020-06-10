using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    public float Currentexp = 0;
    private float Maxexp = 3;
    public int levelCount = 1;

    public Slider sliderexp;
    
    void Start()
    {
        
    }

    void Update()
    {
        gameObject.GetComponent<Text>().text = levelCount.ToString();
        GetExp();
    }


    void GetExp()
    {
        
        if (Currentexp < Maxexp)
        {
            Currentexp = Level.lvl.exp;
            Debug.Log("Current exp: " + Currentexp);
        }
        else
        {
            Debug.Log("Passed");
            Level.lvl.exp = Currentexp - Maxexp;
            Maxexp = Maxexp * 3;
            levelCount += 1;
            
        }
        
    }
}



class Level
{
    public static Level lvl = new Level();

    public float exp = 0;

}
