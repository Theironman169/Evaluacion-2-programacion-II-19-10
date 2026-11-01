
using UnityEngine;
using System.Collections;

public class SpeedPowerUp : MonoBehaviour
{
    public float speedBoost = 2f;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerMovement mov = col.GetComponent<PlayerMovement>();

            if (mov != null)
            {
                mov.StartCoroutine(BoostRoutine(mov));
                Destroy(gameObject);
            }
        }
    }

    private IEnumerator BoostRoutine(PlayerMovement mov)
    {
        mov.speed += speedBoost;

        yield return new WaitForSeconds(duration);

        mov.speed -= speedBoost;
    }
}
