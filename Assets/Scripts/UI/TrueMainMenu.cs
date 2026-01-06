using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueMainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void StartGame()
    {
        SceneManager.LoadScene("RoomScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}