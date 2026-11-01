using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;

    public void TogglePauseMenu(bool show)
    {
        PausePanel.SetActive(show);
    }
}