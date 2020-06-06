using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGameobject : MonoBehaviour
{
    public GameObject boxprefab;
    public GameObject redboxprefab;
    public GameObject classicredboxprefab;

    public float redtimer, redcooldown;
    public float timer, cooldown;
    [SerializeField]
    Transform Selftransform;

    [SerializeField]
    bool IsClassicMode = false;
    private float RandomNum;
    private float RandomNum2;

    private void Start()
    {
        RandomNum = Random.Range(5, 20);
        RandomNum2 = Random.Range(0, 10);
        redcooldown = RandomNum;
        redtimer = RandomNum - 1;
        timer = RandomNum2;
    }

    // Update is called once per frame
    void Update()
    {
        //spawn
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            Spawn();
            timer = cooldown;
        }

        //redspawn
        if (redtimer > 0)
        {
            redtimer -= Time.deltaTime;
        }
        if (redtimer < 0)
        {
            if (IsClassicMode)
                ClassicModeRedSpawn();
            else
                RedSpawn();

            redtimer = redcooldown;
        }

    }


    void Spawn()
    {
        Instantiate(boxprefab, Selftransform);
    }

    void RedSpawn()
    {
        Instantiate(redboxprefab, Selftransform);
    }

    void ClassicModeRedSpawn()
    {
        Instantiate(classicredboxprefab, Selftransform);
    }

}
