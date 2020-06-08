using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGameobject : MonoBehaviour
{
    public GameObject boxprefab;
    public GameObject redboxprefab;
    public GameObject classicredboxprefab;
    public GameObject pyroprefab;

    private float redtimer, redcooldown;
    public float timer, cooldown;
    private float pyrotimer, pyrocooldown;
    [SerializeField]
    Transform Selftransform;

    [SerializeField]
    bool IsClassicMode = false;
    private float RandomNum;
    private float RandomNum2;
    private float RandomNum3;

    private void Start()
    {
        RandomNum = Random.Range(7, 30);
        RandomNum2 = Random.Range(0, 10);
        RandomNum3 = Random.Range(17, 100);
        redcooldown = RandomNum;
        redtimer = RandomNum - 1;
        timer = RandomNum2;
        pyrotimer = RandomNum3;
    }

    // Update is called once per frame
    void Update()
    {
        RedSpawn();

        OtherObjSpawn();

    }


    void RedSpawn()
    {
        //redspawn
        if (redtimer > 0)
        {
            redtimer -= Time.deltaTime;
        }
        if (redtimer < 0)
        {
            if (IsClassicMode)
                SpawnGameObject(classicredboxprefab);
            else
                SpawnGameObject(redboxprefab);

            redtimer = redcooldown;
        }
    }

    void OtherObjSpawn()
    {
        //spawnPyro
        if (pyrotimer > 0)
        {
            pyrotimer -= Time.deltaTime;          
        }
        else
        {
            //Debug.Log("Spawned Pyro");
            SpawnGameObject(pyroprefab);
            pyrotimer = RandomNum3;
        }

        //spawnBOX
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            SpawnGameObject(boxprefab);
            timer = cooldown;
        }
    }

    void SpawnGameObject(GameObject prefab)
    {
        Instantiate(prefab, Selftransform);
    }

}
