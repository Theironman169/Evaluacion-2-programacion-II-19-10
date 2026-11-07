using UnityEngine;

public class ItemBase : MonoBehaviour
{
    public int pointsReward = 5;
    public string pickupMessage = "¡Ítem conseguido!";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log(pickupMessage);

            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddPoints(pointsReward);
            }

            Destroy(gameObject);
        }
    }
}