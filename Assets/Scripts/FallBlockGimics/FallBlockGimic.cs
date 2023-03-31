using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBlockGimic : MonoBehaviour
{
    public bool fall;

    EbiGameController game;
    public float x;
    public float y;
    public float z;
    void Start()
    {
        GameObject obj = GameObject.Find("GameController");
        game = obj.GetComponent<EbiGameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fall & transform.position.y > -6)
        {
            transform.position += new Vector3(0, -4.7f, 0) * Time.deltaTime;
        }

        if (game.scene == 0)
        {
            transform.position = new Vector3(x, y, z);
            fall = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            fall = true;
        }
    }
}
