using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject quitConfirmUI;

    private bool isPaused = false;

    void Awake()
    {
        pauseMenuUI.SetActive(false);
        quitConfirmUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(quitConfirmUI.activeSelf)
            {
                CancelQuit();
                return;
            }
            if (isPaused)
            {
                Resume();
            }
            else
            {
                ShowBookContent.isReading = true;
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        quitConfirmUI.SetActive(false);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        Time.timeScale = 1f;
        isPaused = false;
        ShowBookContent.isReading = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        quitConfirmUI.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void OpenQuitConfirmation()
    {
        pauseMenuUI.SetActive(false);
        quitConfirmUI.SetActive(true);
    }

    public void ConfirmQuit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void CancelQuit()
    {
        pauseMenuUI.SetActive(true);
        quitConfirmUI.SetActive(false);
        isPaused = true;
    }
}

