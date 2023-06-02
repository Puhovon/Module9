using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnGravity : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {

        Debug.Log("Enter");
        {
            var rb = collider.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = false;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        Debug.Log("Exit");
        if (collider.gameObject.name == "Ball")
        {
            var rb = collider.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
        }
    }

    //    Debug.Log("Enter");
    //    {
    //        var rb = collision.gameObject.GetComponent<Rigidbody>();
    //        rb.useGravity = false;
    //    }

    //}

    //void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log("Exit");
    //    if (collision.gameObject.name == "Ball")
    //    {
    //        var rb = collision.gameObject.GetComponent<Rigidbody>();
    //        rb.useGravity = true;
    //    }
    //}
}
