
using UnityEngine;

public class DamagePowerUp : MonoBehaviour
{
    public int extraDamage = 5;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerDamage playerDamage = col.GetComponent<PlayerDamage>();

            if (playerDamage != null)
            {
                playerDamage.AddDamage(extraDamage);
                Destroy(gameObject);
            }
        }
    }
}
