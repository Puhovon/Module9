using UnityEngine;

public class UnGravity : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider)
    {

        Debug.Log("Enter");
        {
            var rb = collider.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = false;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("Exit");
        if (collider.gameObject.name == "Ball")
        {
            var rb = collider.gameObject.GetComponent<Rigidbody>();
            rb.useGravity = true;
        }
    }
}
