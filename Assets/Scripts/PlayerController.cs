using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public bool hpDecrease;

    EbiGameController game;
    EbiHPController hp;
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        ground = false;
        walk = GetComponent<Animator>();
        dead = GetComponent<Animator>();
        transform.position = new Vector3(-2.2f, -2, 0);

        GameObject obj = GameObject.Find("GameController");
        game = obj.GetComponent<EbiGameController>();
        GameObject obj2 = GameObject.Find("HPText");
        hp = obj2.GetComponent<EbiHPController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (game.scene == 1)
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
                    transform.position += new Vector3(4.7f, 0, 0) * Time.deltaTime;
                }
                else if (Input.GetKey(KeyCode.LeftArrow) & !gameOver)
                {
                    walk.SetBool("BlWalk", true);
                    transform.localScale = new Vector3(-3, 3, 3);
                    transform.position += new Vector3(-4.7f, 0, 0) * Time.deltaTime;
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
                    game.scene = 0;

                    if (!hpDecrease)
                    {
                        hp.hp -= 1;
                        hpDecrease = true;
                        if (hp.hp < 1)
                        {
                            SceneManager.LoadScene("EbiGameOver");
                        }
                    }
                }
            }
            else
            {
                if (transform.position.x < 173)
                {
                    walk.SetBool("BlWalk", true);
                    transform.localScale = new Vector3(3, 3, 3);
                    transform.position += new Vector3(1.41f, 0, 0) * Time.deltaTime;
                }
                else
                {
                    playerSprite.enabled = false;
                    StartCoroutine("ClearWait");
                }
            }
        }
        else if (game.scene == 0)
        {
            transform.position = new Vector3(-2.56f, -2, 0);
            gameOver = false;
            box.enabled = true;
            rb.isKinematic = false;
            hpDecrease = false;
            walk.SetBool("BlWalk", false);
            dead.SetBool("BlDead", false);
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

    IEnumerator ClearWait()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("EbiGameClear");
        Debug.Log("Clear");
    }
}
