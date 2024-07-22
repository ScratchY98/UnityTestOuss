using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 500f;

    //Les 4 variables ci-dessous vérifie si le joueur touche le sol, ne fait pas attention à ça c'est d'un niveau un peu élevé ...
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundCheckCollisionsLayer;
    private bool isGrounded;


    public Rigidbody playerRb;

    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");

        //Vérifie si le joueur touche le sol, ne fait pas attention à ça c'est d'un niveau un peu élevé ...
        Collider[] colliders = Physics.OverlapSphere(groundCheck.position, groundCheckRadius, groundCheckCollisionsLayer);
        isGrounded = colliders.Length > 0;

        if (Input.GetButtonUp("Jump") && isGrounded)
        {
            playerRb.AddForce(new Vector3(0f, jumpForce), 0f);
        }

    }
}
