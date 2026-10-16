
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator anim;

    public void SetMoving(bool isMoving)
    {
        anim.SetBool("IsMoving", isMoving);
    }

    public void SetMoveX(float moveX)
    {
        anim.SetFloat("MoveX", moveX);
    }

    public void SetJumping(bool isJumping)
    {
        anim.SetBool("IsJumping", isJumping);
    }
}
