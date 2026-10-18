
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;

    private int currentHealth;
    private Player_Sounds playerSounds;

    private void Start()
    {
        currentHealth = maxHealth;
        playerSounds = GetComponent<Player_Sounds>();

        Debug.Log("Player starting health: " + currentHealth);
    }

    public void TakeDamage(int damage)
    {
        if (playerSounds != null)
        {
            playerSounds.PlayHurtSound();
        }

        currentHealth -= damage;

        Debug.Log("Player hit! Remaining health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player has died! Restarting level...");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
