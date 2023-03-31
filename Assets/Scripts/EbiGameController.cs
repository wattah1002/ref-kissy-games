using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EbiGameController : MonoBehaviour
{
    public int scene = 0;
    public AudioSource gameMusic;
    bool musicStart;

    PlayerController player;
    void Start()
    {
        gameMusic = GetComponent<AudioSource>();

        GameObject obj = GameObject.Find("Player");
        player= obj.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scene == 0 & Input.anyKey)
        {
            scene = 1;
        }

        if (scene == 1 & !musicStart)
        {
            gameMusic.Play();
            musicStart = true;
        }

        if (player.gameOver)
        {
           gameMusic.Stop();
        }

        if (scene == 0)
        {
            musicStart = false;
        }
        
    }
}
