using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockGimic : MonoBehaviour
{
    private Animator move;

    EbiGameController game;
    void Start()
    {
        move = GetComponent<Animator>();
        GameObject obj = GameObject.Find("GameController");
        game = obj.GetComponent<EbiGameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.scene == 0)
        {
            move.SetBool("BlMove", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            move.SetBool("BlMove", true);
        }
    }
}
