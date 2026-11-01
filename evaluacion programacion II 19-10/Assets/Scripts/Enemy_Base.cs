
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int life = 3;
    public int damage = 10;

    private EnemyLoot enemyLoot;

    private void Start()
    {
        enemyLoot = GetComponent<EnemyLoot>();
    }

    public void TakeDamage(int cantidad)
    {
        life -= cantidad;

        if (life <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (enemyLoot != null)
        {
            enemyLoot.DropLoot();
        }

        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }
}
