
using UnityEngine;

public class Projectil : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    [SerializeField] private float lifeTime = 3f;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    public void SetDamage(int extraDamage)
    {
        damage += extraDamage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            EnemyBase enemy = collision.GetComponent<EnemyBase>();

            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
        else if (collision.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
