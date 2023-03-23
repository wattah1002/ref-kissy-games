using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaMove : MonoBehaviour
{
<<<<<<< HEAD
    public float span = 1f;
=======
    public GameObject spawner;
    float gameSpeed;
    public float span;         // 座標移動の間隔
>>>>>>> db7ad8b50f8a8dce5231bfb4cc29c693f896cc16
    public float moveSpeed = 0.1f;
    public float start = -1f;
    public float top = 0.8f;
    float currentTime = 0f;
    bool is_rising = true;
    float currentHeight = -1f;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD

=======
        spawner = GameObject.Find("SpawnHa");
        gameSpeed = spawner.GetComponent<SpawnOyashirazu>().gameSpeed;
>>>>>>> db7ad8b50f8a8dce5231bfb4cc29c693f896cc16
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
<<<<<<< HEAD
        if (is_rising && currentTime > span)
=======
        if (is_rising && currentTime > span*gameSpeed)
>>>>>>> db7ad8b50f8a8dce5231bfb4cc29c693f896cc16
        {
            transform.position += transform.up * moveSpeed;
            currentHeight += moveSpeed;
            currentTime = 0f;
            if (currentHeight > top)
            {
                is_rising = false;
            }
        }
<<<<<<< HEAD
        else if (currentTime > span)
=======
        else if (currentTime > span*gameSpeed)
>>>>>>> db7ad8b50f8a8dce5231bfb4cc29c693f896cc16
        {
            transform.position += transform.up * -1 * moveSpeed;
            currentHeight -= moveSpeed;
            currentTime = 0f;
            if (currentHeight < start)
            {
                Destroy(gameObject);
            }
        }
    }
}
