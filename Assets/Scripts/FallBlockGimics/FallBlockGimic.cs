using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBlockGimic : MonoBehaviour
{
    public bool fall;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fall & transform.position.y > -6)
        {
            transform.position += new Vector3(0, -0.01f, 0);
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
