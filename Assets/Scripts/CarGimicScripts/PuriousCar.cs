using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuriousCar : MonoBehaviour
{
    public GameObject purious;
    private Animator normal;
    private Animator fast;

    PuriousJudge judge;

    public bool go;

    EbiGameController game;
    public float x;
    public float y;
    public float z;

    AudioSource priousCarAudio;
    public AudioClip priousGo;
    bool musicGo;
    void Start()
    {
        normal = purious.GetComponent<Animator>();
        fast = purious.GetComponent<Animator>();
        priousCarAudio = GetComponent<AudioSource>();

        GameObject obj = GameObject.Find("PuriousGoJudge");
        judge = obj.GetComponent<PuriousJudge>();
        GameObject obj2 = GameObject.Find("GameController");
        game = obj2.GetComponent<EbiGameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (go)
        {
            normal.SetBool("BlGo", true);
            transform.position += new Vector3(0.376f, 0, 0) * Time.deltaTime;
        }

        if (judge.letsGo & transform.position.y < 180)
        {
            fast.SetBool("BlAccel", true);
            transform.position += new Vector3(11.75f, 0, 0) * Time.deltaTime;

            if (!musicGo)
            {
                priousCarAudio.PlayOneShot(priousGo);
                musicGo = true;
            }
        }

        if (game.scene == 0)
        {
            transform.position = new Vector3(x, y, z);
            normal.SetBool("BlGo", false);
            fast.SetBool("BlAccel", false);
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
