using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCarGimic : MonoBehaviour
{
    public bool go;
    public GameObject car;
    public Animator start;
    void Start()
    {
        start = car.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (go & transform.position.x > -20)
        {
            transform.position += new Vector3(-0.025f, 0, 0);
            start.SetBool("BlGo", true);
        }
        else
        {
            start.SetBool("BlGo", false);
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
