
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;

    private int currentHealth;
    private Player_Sounds playerSounds;
    private bool isDead;

    private void Start()
    {
        currentHealth = maxHealth;
        playerSounds = GetComponent<Player_Sounds>();

        Debug.Log("Player starting health: " + currentHealth);
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        if (playerSounds != null)
        {
            playerSounds.PlayHurtSound();
        }

        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0);

        Debug.Log("Player hit! Remaining health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (isDead) return;

        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);

        Debug.Log("Player healed! Current health: " + currentHealth);
    }

    private void Die()
    {
        isDead = true;

        Debug.Log("Player has died! Restarting level...");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
