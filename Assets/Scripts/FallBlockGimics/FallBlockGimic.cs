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

    AudioSource blockAudio;
    public AudioClip blockFall;
    bool fallGo;
    void Start()
    {
        GameObject obj = GameObject.Find("GameController");
        game = obj.GetComponent<EbiGameController>();
        blockAudio = obj.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fall & transform.position.y > -10)
        {
            transform.position += new Vector3(0, -4.7f, 0) * Time.deltaTime;
            if (!fallGo)
            {
                blockAudio.PlayOneShot(blockFall);
                fallGo = true;
            }
        }

        if (game.scene == 0)
        {
            transform.position = new Vector3(x, y, z);
            fall = false;
            fallGo = false;
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
