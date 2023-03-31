using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nya : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "CAT")
        {
            Debug.Log("nya");
            GetComponent<AudioSource>().PlayOneShot(audioSource.clip, 3);


        }
    }
}
