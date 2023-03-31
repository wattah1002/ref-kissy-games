using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeichanCameraMove : MonoBehaviour
{
    public Transform cameraHor;
    float horMax = 90f;
    float verMax = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        float hor = cameraHor.eulerAngles.y;

        float changeAngle = X_Rotation * 2;
        if (hor + changeAngle > horMax && hor + changeAngle < 180)
        {
            changeAngle = 0f;
        }
        else if (hor + changeAngle < 360 - horMax && hor + changeAngle > 180)
        {
            changeAngle = 0f;
        }
        cameraHor.transform.Rotate(new Vector3(0, changeAngle, 0));

    }
}
