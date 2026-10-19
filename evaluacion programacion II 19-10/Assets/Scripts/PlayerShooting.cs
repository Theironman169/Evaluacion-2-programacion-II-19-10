
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed = 12f;
    [SerializeField] private Transform weapon;

    private float direction = 1f;
    private Vector3 weaponStartPosition;

    private void Start()
    {
        if (weapon != null)
        {
            weaponStartPosition = weapon.localPosition;
        }
    }

    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput > 0)
        {
            direction = 1f;
        }
        else if (moveInput < 0)
        {
            direction = -1f;
        }

        if (weapon != null)
        {
            Vector3 scale = weapon.localScale;
            scale.x = Mathf.Abs(scale.x) * direction;
            weapon.localScale = scale;

            weapon.localPosition = new Vector3(
                Mathf.Abs(weaponStartPosition.x) * direction,
                weaponStartPosition.y,
                weaponStartPosition.z
            );
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Quaternion rotation = direction < 0
            ? Quaternion.Euler(0f, 180f, 0f)
            : Quaternion.identity;

        GameObject bullet = Instantiate(
            bulletPrefab,
            firePoint.position,
            rotation
        );

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = new Vector2(
                direction * bulletSpeed,
                0f
            );
        }
    }
}
