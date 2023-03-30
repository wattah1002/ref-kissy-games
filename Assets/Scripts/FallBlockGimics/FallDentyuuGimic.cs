using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDentyuuGimic : MonoBehaviour
{
    public bool fall1;
    public float fallDirection = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fall1 & transform.position.y > fallDirection)
        {
            transform.position += new Vector3(0, -0.06f, 0);
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
