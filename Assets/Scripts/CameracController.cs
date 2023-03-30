using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameracController : MonoBehaviour
{
    public GameObject player;

    EbiGameController game;
    void Start()
    {
        GameObject obj = GameObject.Find("GameController");
        game = obj.GetComponent<EbiGameController>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform playerPos = player.transform;
        Vector2 worldPos = playerPos.position;
        Vector2 vewPos = Camera.main.WorldToScreenPoint(worldPos);
        if (vewPos.x > 1000)
        {
            this.transform.position += new Vector3(0.01f, 0, 0);
        }
        else if (vewPos.x < 500 & worldPos.x > -4)
        {
            this.transform.position += new Vector3(-0.01f, 0, 0);
        }
    }
}
