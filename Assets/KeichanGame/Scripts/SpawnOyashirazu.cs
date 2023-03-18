using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class SpawnOyashirazu : MonoBehaviour
{
    public GameObject haPre;
    public GameObject timer;
    public int split = 10;          // 歯と歯の間隔
    public float distance = 7.3f;   // 原点からの距離
    float deg;
    public float gameSpeed = 1;
    float timeCount = 0;
    int maxLevel = 4;

    // Start is called before the first frame update
    void Start()
    {
        deg = 180 / split;
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        Timer t = timer.GetComponent<Timer>();
        gameSpeed = (float)Math.Ceiling(t.remainingTime / t.timeLimit * 4) / 4;
        timeCount += Time.deltaTime;
        if (timeCount >= gameSpeed)
        {
            Spawn();
            timeCount = 0;
        }
        Debug.Log("timeCount:" + timeCount);
        Debug.Log("gameSpeed:" + gameSpeed);
        Debug.Log("bool:" + (timeCount >= gameSpeed));
        Debug.Log("---------");
    }

    void Spawn()
    {
        int rand = Random.Range(0, split + 1);
        float degX = (float)Math.Cos((rand * deg) * (Math.PI / 180));
        float degZ = (float)Math.Sin((rand * deg) * (Math.PI / 180));
        Vector3 pos = new Vector3(distance * degX, -1f, distance * degZ);
        GameObject haObj = Instantiate(haPre, pos, Quaternion.Euler(0, 90 - (rand * deg), 0));
    }
}
