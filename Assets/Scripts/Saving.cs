using UnityEngine;
using System.IO;
using System;

public class Saving : MonoBehaviour
{
    public GameObject namePan;

    private Save sv = new Save();
    private string path;

    private void Start()
    {

        path = Path.Combine(Application.persistentDataPath, "Save.json");

        if (File.Exists(path))
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));
            Debug.Log("Добро пожаловать: " + sv.name + "\nВаш возраст: " + sv.age);
        }
        else namePan.SetActive(true);
    }

    //public void CheckName(string name)
    //{
    //    if (!string.IsNullOrEmpty(name) && name.Length >= 3)
    //    {
    //        sv.name = name;
    //        Debug.Log("Ваше имя: " + name);
    //    }
    //    else Debug.Log("Введите нормальное имя!");
    //}
    //public void CheckAge(string age)
    //{
    //    if (!string.IsNullOrEmpty(age) && age.Length > 0)
    //    {
    //        sv.age = int.Parse(age);
    //        Debug.Log("Ваш возраст: " + age);
    //    }
    //    else Debug.Log("Введите нормальный возраст!");
    //}

    private void OnApplicationPause(bool pause)
    {
        if (pause) File.WriteAllText(path, JsonUtility.ToJson(sv));
    }

    private void OnApplicationQuit()
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

    Save()
    {
        currentexpStat = Level.lvl.currentexpStat;
        MaxexpStat = Level.lvl.MaxexpStat;
        levelCountStat = Level.lvl.levelCountStat;
    }
}

