using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameracController : MonoBehaviour
{
    public GameObject player;

    EbiGameController game;
    private bool move;
    void Start()
    {
        GameObject obj = GameObject.Find("GameController");
        game = obj.GetComponent<EbiGameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.scene == 1)
        {
            if (move)
            {
                transform.position = new Vector3(0, 1, -10);
                move= false;
            }

            Transform playerPos = player.transform;
            Vector2 worldPos = playerPos.position;
            Vector2 vewPos = Camera.main.WorldToScreenPoint(worldPos);
            if (vewPos.x > 1000)
            {
                this.transform.position += new Vector3(4.7f, 0, 0) * Time.deltaTime;
            }
            else if (vewPos.x < 500 & worldPos.x > -4)
            {
                this.transform.position += new Vector3(-4.7f, 0, 0) * Time.deltaTime;
            }
        } else if (game.scene == 0)
        {
            transform.position = new Vector3(-19.8f, 1, -10);
            move = true;
        }
        
    }
}
