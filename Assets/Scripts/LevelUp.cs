using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    public float exp;
    public int levelCount;

    public Text leveltext;
    public Slider sliderexp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



class Level
{
    public static Level lvl = new Level();

    public float exp = 0;

}
