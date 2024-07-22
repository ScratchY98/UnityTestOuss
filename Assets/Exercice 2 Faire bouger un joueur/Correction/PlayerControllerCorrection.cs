using UnityEngine;

public class PlayerControllerCorrection : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;

    private float horizontalMovement;
    private float verticalMovement;

    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalMovement, 0, verticalMovement) * speed;
    }
}
