
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadInicio()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadNivel()
    {
        SceneManager.LoadScene("pruebas");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
