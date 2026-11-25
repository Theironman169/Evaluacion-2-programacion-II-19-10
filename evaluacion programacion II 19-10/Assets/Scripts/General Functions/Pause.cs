
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private GameObject player;

    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        player.SetActive(false);

        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(true);

        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        player.SetActive(true);

        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(false);

        isPaused = false;
    }
}
