using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectingMenu : MonoBehaviour
{

    public GameObject classicrecord;
    public GameObject arcaderecord;
    public GameObject RecordPanel;


    public void GetRecords()
    {
        RecordPanel.SetActive(true);

        classicrecord.GetComponent<Text>().text = "Classic record: " + ResultClass.Inst.ClassicResult.ToString();
        arcaderecord.GetComponent<Text>().text = "Arcade record: " + ResultClass.Inst.ArcadeResult.ToString();

        Debug.Log("Classic result: " + ResultClass.Inst.ClassicResult);
        Debug.Log("Arcade result: " + ResultClass.Inst.ArcadeResult);
    }
}
