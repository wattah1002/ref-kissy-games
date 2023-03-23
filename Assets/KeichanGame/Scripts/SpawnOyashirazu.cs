using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class SpawnOyashirazu : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject ha;
    public int split = 10;
    public float distance = 7.3f;
    float deg;

=======
    public GameObject haPre;
    public GameObject timer;
    public int split = 10;          // 歯と歯の間隔
    public float distance = 7.3f;   // 原点からの距離
    float deg;
    public float gameSpeed = 1;
    float timeCount = 0;
    int maxLevel = 4;
>>>>>>> db7ad8b50f8a8dce5231bfb4cc29c693f896cc16

    // Start is called before the first frame update
    void Start()
    {
        deg = 180 / split;
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (Input.GetKeyUp("space"))
        {
            Spawn();
=======
        Timer t = timer.GetComponent<Timer>();
        gameSpeed = (float)Math.Ceiling(t.remainingTime / t.timeLimit * 4) / 4;
        timeCount += Time.deltaTime;
        if (timeCount >= gameSpeed)
        {
            Spawn();
            timeCount = 0;
>>>>>>> db7ad8b50f8a8dce5231bfb4cc29c693f896cc16
        }
    }

    void Spawn()
    {
        int rand = Random.Range(0, split + 1);
        float degX = (float)Math.Cos((rand * deg) * (Math.PI / 180));
        float degZ = (float)Math.Sin((rand * deg) * (Math.PI / 180));
        Vector3 pos = new Vector3(distance * degX, -1f, distance * degZ);
<<<<<<< HEAD
        Instantiate(ha, pos, Quaternion.Euler(0, 90 - (rand * deg), 0));
=======
        GameObject haObj = Instantiate(haPre, pos, Quaternion.Euler(0, 90 - (rand * deg), 0));
>>>>>>> db7ad8b50f8a8dce5231bfb4cc29c693f896cc16
    }
}
