using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCarGimic : MonoBehaviour
{
    public bool go;
    public GameObject car;
    public Animator start;
    EbiGameController game;
    public float x;
    public float y;
    public float z;

    AudioSource redCarAudio;
    public AudioClip carGo;
    bool musicGo;
    void Start()
    {
        start = car.GetComponent<Animator>();
        GameObject obj = GameObject.Find("GameController");
        game = obj.GetComponent<EbiGameController>();

        redCarAudio= game.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (go & transform.position.x > -20)
        {
            transform.position += new Vector3(-11.75f, 0, 0) * Time.deltaTime;
            start.SetBool("BlGo", true);
        }
        else
        {
            start.SetBool("BlGo", false);
        }

        if (go & !musicGo)
        {
            redCarAudio.PlayOneShot(carGo);
            musicGo = true;
        }

        if (game.scene == 0)
        {
            transform.position = new Vector3(x, y, z);
            start.SetBool("BlGo", false);
            go = false;
            musicGo = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            go = true;
        }
    }
}
