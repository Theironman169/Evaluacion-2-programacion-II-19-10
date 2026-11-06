
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10f;
    public Rigidbody2D RigidbodyPlayer;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius = 0.2f;

    [SerializeField] private PlayerAnimations playerAnimations;
    [SerializeField] private AudioSource sfxSource;
    [SerializeField] private AudioClip jumpSound;

    private bool isGrounded;

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            groundCheckRadius,
            groundLayer
        );

        if (playerAnimations != null)
        {
            playerAnimations.SetJumping(!isGrounded);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            RigidbodyPlayer.linearVelocity = new Vector2(
                RigidbodyPlayer.linearVelocity.x,
                jumpForce
            );

            if (sfxSource != null && jumpSound != null)
            {
                sfxSource.PlayOneShot(jumpSound);
            }
        }
    }
}
