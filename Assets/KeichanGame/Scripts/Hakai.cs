using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hakai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void destroyObject()
    {
        var random = new System.Random();
        var min = -3;
        var max = 3;
        gameObject.GetComponentsInChildren<Rigidbody>().ToList().ForEach(r =>
        {
            r.isKinematic = false;
            r.transform.SetParent(null);
            r.gameObject.AddComponent<DestroyScrap>();
            var vect = new Vector3(random.Next(min, max), random.Next(0, max), random.Next(min, max));
            r.AddForce(vect, ForceMode.Impulse);
            r.AddTorque(vect, ForceMode.Impulse);
        });
        Destroy(gameObject, 3.0f);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hammer")
        {
            destroyObject();
        }

    }
}
