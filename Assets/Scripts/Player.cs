using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 initialPosition = new Vector3(0, 1, 0);
    public Rotation floor;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void ResetPosition()
    {

        if (rb != null)
        {
            rb.angularVelocity = Vector3.zero;
            rb.linearVelocity = Vector3.zero;
        }

        if (floor != null)
        {
            floor.ResetRotation();
        }

        transform.position = initialPosition;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destructor"))
        {
            ResetPosition();
        }  
    }
}
