using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootDentyuuBlock : MonoBehaviour
{
    public BoxCollider2D block;
    EbiGameController game;
    void Start()
    {
        block = GetComponent<BoxCollider2D>();
        GameObject obj = GameObject.Find("GameController");
        game = obj.GetComponent<EbiGameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.scene == 0)
        {
            block.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            block.enabled = false;
        }
    }
}
