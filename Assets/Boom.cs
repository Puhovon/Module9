using UnityEngine;

public class Boom : MonoBehaviour
{
    [SerializeField] private float timeToExplosion,
        radius,
        power;
    // Update is called once per frame
    private void Update()
    {
        timeToExplosion -= Time.deltaTime;

        if (timeToExplosion <= 0)
        {
            Btoom();
        }
    }

    private void Btoom()
    {
        Rigidbody[] balls = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody rb in balls)
        {
            var distance = Vector3.Distance(transform.position, rb.transform.position);
            if (distance < radius && rb.gameObject.name.Contains("Ball"))
            {
                Vector3 direction = rb.transform.position - transform.position;


                rb.AddForce(direction.normalized * power * (radius - distance), ForceMode.Impulse);
            }
        }
    }
}
