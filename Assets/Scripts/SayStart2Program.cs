using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayStart2Program : MonoBehaviour
{
    public GameObject SayStart2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CAT")
        {
            Debug.Log("Start");
            SayStart2.SetActive(true);
        }
    }
}
