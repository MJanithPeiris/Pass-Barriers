using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 4000 * Time.deltaTime);
    }
}