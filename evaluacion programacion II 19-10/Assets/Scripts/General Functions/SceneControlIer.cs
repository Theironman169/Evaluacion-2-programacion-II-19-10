
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadInicio()
    {
        SceneManager.LoadScene("MainMenu"); //esta carga el nivel para empezar a jugar desde la escena de menu principal presionando el boton "Play"
    }

    public void LoadNivel()
    {
        SceneManager.LoadScene("pruebas"); //escena del nivel
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver"); //esta faltaria agregar
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
