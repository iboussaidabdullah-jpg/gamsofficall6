using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 25f;
    public float turnSpeed = 80f;

    public Rigidbody rb;

    void FixedUpdate()
    {
        float move = Input.GetAxis("Vertical") * speed;
        float turn = Input.GetAxis("Horizontal") * turnSpeed;

        Vector3 direction = transform.forward * move;
        rb.AddForce(direction);

        transform.Rotate(0, turn * Time.deltaTime, 0);
    }
}
