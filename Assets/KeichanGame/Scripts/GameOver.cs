using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject spawner;
    public GameObject camera;
    void Awake()
    {
        gameObject.SetActive(false);
    }
    void OnEnable()
    {

        // spawner.GetComponent<SpawnOyashirazu>().enabled = false;
        camera.GetComponent<CameraMove>().enabled = false;
        spawner.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene("KeichanScene");
        }
        if (Input.GetKey("t"))
        {
            SceneManager.LoadScene("HomeScene");
        }

    }
}
