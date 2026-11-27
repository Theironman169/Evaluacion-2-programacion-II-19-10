using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public Collider2D PortalCollider;

    private void Awake()
    {
        PortalCollider = GetComponent<Collider2D>();

        if (PortalCollider != null) PortalCollider.enabled = false;
    }

    private void Update()
    {
        if (PortalCollider != null && !PortalCollider.enabled)
        {
            int GetApple = GameObject.FindGameObjectsWithTag("Abierto").Length;

            if (GetApple == 0)
            {
                PortalCollider.enabled = true;
            }
        }
    }
}
