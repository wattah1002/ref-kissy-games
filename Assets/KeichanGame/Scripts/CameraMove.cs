using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform cameraVer;
    public Transform cameraHor;
    float horMax = 13f;
    float verMax = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        float hor = cameraHor.eulerAngles.x;
        float ver = cameraVer.eulerAngles.y;

        cameraVer.transform.Rotate(new Vector3(0, X_Rotation * 2, 0));
        cameraHor.transform.Rotate(-Y_Rotation * 2, 0, 0);
        if (hor > 13 && hor < 180)
        {
            cameraHor.transform.rotation = Quaternion.Euler(13, cameraVer.eulerAngles.y, 0);
        }
        if (hor < 360 - horMax && hor > 180)
        {
            cameraHor.transform.rotation = Quaternion.Euler(-1 * horMax, cameraVer.eulerAngles.y, 0);
        }

        // if (ver < 360 - verMax && ver > 180)
        // {
        //     cameraVer.transform.rotation = Quaternion.Euler(cameraHor.eulerAngles.x, -1 * verMax, 0);
        // }
        // if (ver < verMax && ver > 180)
        // {
        //     cameraVer.transform.rotation = Quaternion.Euler(cameraHor.eulerAngles.x, verMax, 0);
        // }
    }
}
