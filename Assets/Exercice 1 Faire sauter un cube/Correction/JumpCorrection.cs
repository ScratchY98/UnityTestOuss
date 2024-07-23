using UnityEngine;

public class JumpCorrection : MonoBehaviour
{
    public float jumpForce = 500f; // Variable pour la force du saut.

    // Les 4 variables ci-dessous v�rifie si le joueur touche le sol, ne fait pas attention � �a c'est d'un niveau un peu �lev� ...
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundCheckCollisionsLayer;
    private bool isGrounded;

    public Rigidbody playerRb; // Variable du Rigidbody.

    void Update()
    {
        // V�rifie si le joueur touche le sol, ne fait pas attention � �a c'est d'un niveau un peu �lev� ...
        Collider[] colliders = Physics.OverlapSphere(groundCheck.position, groundCheckRadius, groundCheckCollisionsLayer);
        isGrounded = colliders.Length > 0;

        if (Input.GetButtonUp("Jump") && isGrounded)
        {
            playerRb.AddForce(new Vector3(0f, jumpForce), 0f);
        }

    }
}
