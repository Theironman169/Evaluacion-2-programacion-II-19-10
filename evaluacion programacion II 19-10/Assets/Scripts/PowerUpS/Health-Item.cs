using UnityEngine;

public class HealthItem : MonoBehaviour
{
    public int healAmount = 20;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerHealth health = col.GetComponent<PlayerHealth>();

            if (health != null)
            {
                health.Heal(healAmount);
            }
        }
    }
}