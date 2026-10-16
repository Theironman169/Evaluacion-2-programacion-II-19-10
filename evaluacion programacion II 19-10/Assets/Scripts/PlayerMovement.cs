
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D RigidbodyPlayer;

    [SerializeField] private PlayerAnimations playerAnimations;

    private float moveInput;

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");


        if (playerAnimations != null)
        {
            playerAnimations.SetMoving(moveInput != 0);
            playerAnimations.SetMoveX(moveInput);
        }
    }

    void FixedUpdate()
    {
        RigidbodyPlayer.linearVelocity = new Vector2(
            moveInput * speed,
            RigidbodyPlayer.linearVelocity.y
        );
    }
}
