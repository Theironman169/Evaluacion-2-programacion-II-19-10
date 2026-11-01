using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PauseMenu pauseMenu;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        Time.timeScale = isPaused ? 0f : 1f;

        pauseMenu.TogglePauseMenu(isPaused);
    }
}