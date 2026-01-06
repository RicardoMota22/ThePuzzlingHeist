using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueMainMenu : MonoBehaviour
{
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