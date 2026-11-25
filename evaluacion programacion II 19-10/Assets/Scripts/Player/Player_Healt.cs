
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private Slider healthBar;
    [SerializeField] private GameObject gameOverPanel;

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

        gameOverPanel.SetActive(false);
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        if (playerSounds != null)
            playerSounds.PlayHurtSound();

        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0);

        healthBar.value = currentHealth;

        if (currentHealth <= 0)
            Die();
    }

    public void Heal(int amount)
    {
        if (isDead) return;

        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        healthBar.value = currentHealth;
    }

    private void Die()
    {
        isDead = true;
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
