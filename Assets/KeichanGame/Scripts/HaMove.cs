using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaMove : MonoBehaviour
{
    public GameObject spawner;
    float gameSpeed;
    public float span;         // 座標移動の間隔
    public float moveSpeed = 0.1f;
    public float start = -1f;
    public float top = 0.8f;
    float currentTime = 0f;
    bool is_rising = true;
    float currentHeight = -1f;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.Find("SpawnHa");
        gameSpeed = spawner.GetComponent<SpawnOyashirazu>().gameSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (is_rising && currentTime > span*gameSpeed)
        {
            transform.position += transform.up * moveSpeed;
            currentHeight += moveSpeed;
            currentTime = 0f;
            if (currentHeight > top)
            {
                is_rising = false;
            }
        }
        else if (currentTime > span*gameSpeed)
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
