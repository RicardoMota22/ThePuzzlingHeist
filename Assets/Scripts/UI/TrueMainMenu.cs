using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TrueMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject overviewMenu;
    private bool inOverview;
    [SerializeField] private Button startButton;
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        inOverview = false;
        mainMenu.SetActive(true);
        overviewMenu.SetActive(false);

        EventSystem.current.SetSelectedGameObject(startButton.gameObject);
    }
    
    void Update()
    {
        if(/*Input.GetButtonDown("Interact")*/PlayerInputHandler.Instance.Controls.Player.Interact.WasPressedThisFrame() && inOverview)
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