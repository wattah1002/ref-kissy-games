using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMoveKirari : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool Grounded;

    AudioSource audioSource;
    private Vector2 gravityCount;
    public Text gravityText;
    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = rb.velocity;
        v.x = Input.GetAxis("Horizontal");
        rb.velocity = v;
        gravityCount = v;
        gravityText.text = gravityCount.ToString();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            arrow.SetActive(true);
            transform.localScale = new Vector3(0.2f, 0.2f, 0.5f);
            transform.position += new Vector3(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(-0.2f, 0.2f, 0.5f);
            transform.position += new Vector3(-0.05f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && Grounded == true)
        {
            rb.AddForce(Vector2.up * 300);

            GetComponent<AudioSource>().PlayOneShot(audioSource.clip);
        }
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("KirariScene");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
        {
            Grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
        {
            Grounded = false;
        }
    }




    //private void OnTriggerEnter2D(Collision collision)
    //{
    //    if(collision.gameObject.tag == "coin")
    //    {
    //        Destroy(gameObject);
    //        Debug.Log("aaaa");
    //    }
    //}
}
