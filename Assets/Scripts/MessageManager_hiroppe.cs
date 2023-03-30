using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageManager_hiroppe : MonoBehaviour
{
    public GameObject _text;
    public Text message;

    private float shakePower = 4f;
    void Start()
    {
        StartCoroutine("StartPerform");
    }

    // Update is called once per frame
    void Update()
    {
        _text.transform.Rotate(0,0,shakePower);
        shakePower = -1 * shakePower;
    }

    public void SetText(string text){
        _text.SetActive(true);
        message.GetComponent<Text>().text = text;
    }
    
    IEnumerator StartPerform(){
        SetText("えらべ！");
        yield return new WaitForSeconds(1);
        _text.SetActive(false);
    }
}
