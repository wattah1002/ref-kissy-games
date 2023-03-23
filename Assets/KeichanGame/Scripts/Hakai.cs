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
<<<<<<< HEAD
            // Destroy(r, 2.0f);
=======
            r.gameObject.AddComponent<DestroyScrap>();
>>>>>>> db7ad8b50f8a8dce5231bfb4cc29c693f896cc16
            var vect = new Vector3(random.Next(min, max), random.Next(0, max), random.Next(min, max));
            r.AddForce(vect, ForceMode.Impulse);
            r.AddTorque(vect, ForceMode.Impulse);
        });
<<<<<<< HEAD
        Destroy(gameObject);
=======
        Destroy(gameObject, 3.0f);
>>>>>>> db7ad8b50f8a8dce5231bfb4cc29c693f896cc16

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hammer")
        {
            destroyObject();
        }

    }
}
