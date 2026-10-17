using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("Vida inicial del jugador: " + currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        Debug.Log("¡Jugador atacado! Vida restante: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("¡El jugador ha muerto! Reiniciando nivel...");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}