using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuriousJudge : MonoBehaviour
{
    public bool letsGo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            letsGo= true;
        }
    }
}
