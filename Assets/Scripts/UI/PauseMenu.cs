using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject quitConfirmUI;

    private bool isPaused = false;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button quitYesButton;
    private PlayerControls _controls;

    void Awake()
    {
        pauseMenuUI.SetActive(false);
        quitConfirmUI.SetActive(false);
    }

    void Start()
    {
        _controls = PlayerInputHandler.Instance.Controls;
    }
    void Update()
    {
        if (/*Input.GetKeyDown(KeyCode.Escape)*/_controls.Player.Pause.WasPressedThisFrame())
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
        EventSystem.current.SetSelectedGameObject(resumeButton.gameObject);

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

        EventSystem.current.SetSelectedGameObject(quitYesButton.gameObject);
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

        EventSystem.current.SetSelectedGameObject(resumeButton.gameObject);

        isPaused = true;
    }
}

