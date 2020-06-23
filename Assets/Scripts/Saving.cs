using UnityEngine;
using System.IO;
using System;

public class Saving : MonoBehaviour
{

    private Save save = new Save();
    private string path;

    private void Start()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.persistentDataPath, "Save.json");
#else
        path = Path.Combine(Application.dataPath, "Save.json");
#endif

        //Level.lvl.currentexpStat = save.currentexpStat;
        //Level.lvl.MaxexpStat = save.MaxexpStat;
        //Level.lvl.levelCountStat = save.levelCountStat;

    }


    public void SavingToJson()
    {
        save.currentexpStat = Level.lvl.currentexpStat;
        save.MaxexpStat = Level.lvl.MaxexpStat;
        save.levelCountStat = Level.lvl.levelCountStat;
        string json = JsonUtility.ToJson(save);
        Debug.Log("Saved");
    }


    //public void OnSave()
    //{
        
    //    if (File.Exists(path))
    //    {

    //        Debug.Log("Loaded");
    //    }
    //    else
    //    {
    //        save.currentexpStat = Level.lvl.currentexpStat;
    //        save.MaxexpStat = Level.lvl.MaxexpStat;
    //        save.levelCountStat = Level.lvl.levelCountStat;
    //        Debug.Log("Saved");
    //    }
        
    //    File.WriteAllText(path, JsonUtility.ToJson(save));
    //    save.currentexpStat = Level.lvl.currentexpStat;
    //    save.MaxexpStat = Level.lvl.MaxexpStat;
    //    save.levelCountStat = Level.lvl.levelCountStat;
    //}

    public void OnLoad()
    {
        Level.lvl.currentexpStat= save.currentexpStat;
        Level.lvl.MaxexpStat= save.MaxexpStat;
        Level.lvl.levelCountStat= save.levelCountStat;
        //string json = File.ReadAllText(path);
        //save = JsonUtility.FromJson<Save>(json);
        Debug.Log("Loaded");
    }



    public void OnApplicationPause(bool pause)
    {
        if (pause) File.WriteAllText(path, JsonUtility.ToJson(save));
    }

    public void OnApplicationQuit()
    {
        File.WriteAllText(path, JsonUtility.ToJson(save));
    }

}

[Serializable]
public class Save
{
    public float currentexpStat;
    public float MaxexpStat;
    public int levelCountStat;


    //public void saving()
    //{
    //    currentexpStat = Level.lvl.currentexpStat;
    //    MaxexpStat = Level.lvl.MaxexpStat;
    //    levelCountStat = Level.lvl.levelCountStat;
    //}

}

