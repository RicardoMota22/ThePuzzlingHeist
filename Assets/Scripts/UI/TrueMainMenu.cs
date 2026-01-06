using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject overviewMenu;
    private bool inOverview;
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        inOverview = false;
        mainMenu.SetActive(true);
        overviewMenu.SetActive(false);
    }
    void Update()
    {
        if(Input.GetButtonDown("Interact") && inOverview)
        {
            StartGame();
        }
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
    public void GoToOverview()
    {
        mainMenu.SetActive(false);
        overviewMenu.SetActive(true);
        inOverview = true;
    }
}