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
    void Start()
    {
        normal = purious.GetComponent<Animator>();
        fast = purious.GetComponent<Animator>();

        GameObject obj = GameObject.Find("PuriousGoJudge");
        judge = obj.GetComponent<PuriousJudge>();
    }

    // Update is called once per frame
    void Update()
    {
        if (go)
        {
            normal.SetBool("BlGo", true);
            transform.position += new Vector3(0.0008f, 0, 0);
        }

        if (judge.letsGo & transform.position.y < 180)
        {
            fast.SetBool("BlAccel", true);
            transform.position += new Vector3(0.03f, 0, 0);
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
