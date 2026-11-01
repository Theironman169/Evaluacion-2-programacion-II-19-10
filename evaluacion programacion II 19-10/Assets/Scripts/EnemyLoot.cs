
using UnityEngine;

public class EnemyLoot : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject healthPrefab;

    public void DropLoot()
    {
        if (coinPrefab != null)
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }

        if (healthPrefab != null)
        {
            Instantiate(
                healthPrefab,
                transform.position + Vector3.right * 0.5f,
                Quaternion.identity
            );
        }
    }
}
