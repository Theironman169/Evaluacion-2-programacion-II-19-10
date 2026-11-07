using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private Slider healthBar;

    private int currentHealth;
    private Player_Sounds playerSounds;
    private bool isDead;

    private void Start()
    {
        currentHealth = maxHealth;
        playerSounds = GetComponent<Player_Sounds>();

        healthBar.minValue = 0;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;

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

        healthBar.value = currentHealth;

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

        healthBar.value = currentHealth;

        Debug.Log("Player healed! Current health: " + currentHealth);
    }

    private void Die()
    {
        isDead = true;
        Debug.Log("Player has died! Restarting level...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}