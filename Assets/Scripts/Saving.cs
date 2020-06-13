using UnityEngine;
using System.IO;
using System;

public class Saving : MonoBehaviour
{

    private Save sv = new Save();
    private string path;

    private void Start()
    {

#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.persistentDataPath, "Save.json");
#else
        path = Path.Combine(Application.dataPath, "Save.json");
#endif
        OnSave();
    }

    public void OnSave()
    {
        //rewrite it 
        if (File.Exists(path))
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));
            Level.lvl.currentexpStat = sv.currentexpStat;
            Level.lvl.MaxexpStat = sv.MaxexpStat;
            Level.lvl.levelCountStat = sv.levelCountStat;
            Debug.Log("Loaded");
        }
        else
        {
            sv.currentexpStat = Level.lvl.currentexpStat;
            sv.MaxexpStat = Level.lvl.MaxexpStat;
            sv.levelCountStat = Level.lvl.levelCountStat;
            Debug.Log("Saved");
        }
           
    }


    public void OnApplicationPause(bool pause)
    {
        if (pause) File.WriteAllText(path, JsonUtility.ToJson(sv));
    }

    public void OnApplicationQuit()
    {
        File.WriteAllText(path, JsonUtility.ToJson(sv));
    }
}
[Serializable]
public class Save
{
    public float currentexpStat;
    public float MaxexpStat;
    public int levelCountStat;

    public Save()
    {
        currentexpStat = Level.lvl.currentexpStat;
        MaxexpStat = Level.lvl.MaxexpStat;
        levelCountStat = Level.lvl.levelCountStat;
    }
}

