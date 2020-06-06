using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerArcadeScene : MonoBehaviour
{
    public float min = 1;
    public float sec = 59;
    public Text TimerText;
    public GameObject timeleft;
    public GameObject Spawners;

    void FixedUpdate()
    {
        
        if (sec >= 1)
        {
            sec -= Time.deltaTime;
        }
        else
        {
            if(min != 0)
            {
                min -= 1;
                sec = 60;
            }
            else
            {
                Debug.Log("Over");
                timeleft.SetActive(true);            
                Spawners.SetActive(false);
                Destroy(gameObject.GetComponent<TimerArcadeScene>());
            }
        }

        if (sec<=11 && min == 0)
        {
            TimerText.color = Color.red;
        }

        if (sec < 10)
        {
            TimerText.text = min.ToString() + ":0" + Mathf.FloorToInt(sec).ToString();
        }
        else
        {
            TimerText.text = min.ToString() + ":" + Mathf.FloorToInt(sec).ToString();
        }


    }
}
