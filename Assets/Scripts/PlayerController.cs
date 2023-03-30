using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer playerSprite;
    public Rigidbody2D rb;
    public bool ground;
    private Animator walk;
    private Animator dead;
    public bool gameOver;
    public bool gameOverJump;
    public int gameOverJumpForce;
    public BoxCollider2D box;
    public bool goal;
    public bool clear;
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        ground = false;
        walk = GetComponent<Animator>();
        dead = GetComponent<Animator>();
        transform.position = new Vector3(-2.2f, -2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!goal)
        {
            if (Input.GetKeyDown(KeyCode.Space) & ground & !gameOver)
            {
                rb.AddForce(Vector2.up * 300);
            }

            if (Input.GetKey(KeyCode.RightArrow) & !gameOver)
            {
                walk.SetBool("BlWalk", true);
                transform.localScale = new Vector3(3, 3, 3);
                transform.position += new Vector3(0.01f, 0, 0);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) & !gameOver)
            {
                walk.SetBool("BlWalk", true);
                transform.localScale = new Vector3(-3, 3, 3);
                transform.position += new Vector3(-0.01f, 0, 0);
            }
            else
            {
                walk.SetBool("BlWalk", false);
            }

            if (transform.position.y < -4 & !gameOverJump)
            {
                gameOverJumpForce = 400;
                rb.velocity = Vector3.zero;
                GameOverAction();
            }

            if (transform.position.y < -7)
            {
                rb.isKinematic = true;
                rb.velocity = Vector2.zero;
            }
        } 
        else
        {
            if (transform.position.x < 173)
            {
                walk.SetBool("BlWalk", true);
                transform.localScale = new Vector3(3, 3, 3);
                transform.position += new Vector3(0.003f, 0, 0);
            }
            else
            {
                playerSprite.enabled = false;
                clear = true;
            }
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = true;
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            gameOverJumpForce = 250;
            rb.velocity = Vector3.zero;
            GameOverAction();
        }

        if (collision.gameObject.tag == "BrokenCar")
        {
            gameOverJumpForce = 350;
            rb.velocity = Vector3.zero;
            GameOverAction();
        }

        if (collision.gameObject.tag == "Dentyuu")
        {
            gameOverJumpForce = 300;
            rb.velocity = Vector3.zero;
            GameOverAction();
        }

        if (collision.gameObject.tag == "Goal")
        {
            goal = true;
        }
    }

    void GameOverAction()
    {
        box.enabled = false;
        gameOver = true;
        dead.SetBool("BlDead", true);
        rb.AddForce(Vector2.up * gameOverJumpForce);
        gameOverJump = true;
    }
}
