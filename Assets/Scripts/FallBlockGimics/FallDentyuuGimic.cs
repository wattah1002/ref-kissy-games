using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDentyuuGimic : MonoBehaviour
{
    public bool fall1;
    public float fallDirection = 1;

    public float x;
    public float y;
    public float z;

    EbiGameController game;
    AudioSource dentyuuAudio;
    public AudioClip dentyuuFall;
    bool fallGo;
    void Start()
    {
        GameObject obj = GameObject.Find("GameController");
        game = obj.GetComponent<EbiGameController>();
        dentyuuAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fall1 & transform.position.y > fallDirection)
        {
            transform.position += new Vector3(0, -28.2f, 0) * Time.deltaTime;
            if (!fallGo)
            {
                dentyuuAudio.PlayOneShot(dentyuuFall);
                fallGo = true;
            }
        }

        if (game.scene == 0)
        {
            transform.position = new Vector3(x, y, z);
            fall1 = false;
            fallGo = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            fall1 = true;
        }

    }
}
