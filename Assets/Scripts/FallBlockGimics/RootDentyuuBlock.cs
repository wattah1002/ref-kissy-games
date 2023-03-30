using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootDentyuuBlock : MonoBehaviour
{
    public BoxCollider2D block;
    void Start()
    {
        block = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            block.enabled = false;
        }
    }
}
