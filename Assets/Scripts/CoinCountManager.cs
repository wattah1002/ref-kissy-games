using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountManager : MonoBehaviour
{
    private int coinCount;
    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "CAT")
        {
            
            coinCount += 1;
            Destroy(gameObject);
        }
        coinText.text = coinCount.ToString();
    }

    
    

}
