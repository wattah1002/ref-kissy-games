using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GravityCountManager : MonoBehaviour
{
    private int gravityCount;
    public Text gravityText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        
        gravityText.text = gravityCount.ToString();
    }




}
