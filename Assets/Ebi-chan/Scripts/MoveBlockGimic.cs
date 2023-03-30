using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockGimic : MonoBehaviour
{
    private Animator move;
    void Start()
    {
        move = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            move.SetBool("BlMove", true);
        }
    }
}
