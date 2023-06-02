using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superman : MonoBehaviour
{
    [SerializeField] private Transform endPoint;
    [SerializeField] private int power, speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPoint.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Коллизия с: {collision.gameObject.name}");
        if (collision.gameObject.name == "BadBoy")
        {
            Vector3 center = collision.transform.position - transform.position;
            collision.gameObject.GetComponent<Rigidbody>().AddForce(center.normalized * Convert.ToInt32(Math.Pow(power, 4)),ForceMode.Impulse);

        }
    }
    
}
