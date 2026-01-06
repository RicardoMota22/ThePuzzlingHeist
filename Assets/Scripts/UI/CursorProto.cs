using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public GameObject menuUI; // Assign your menu Canvas or Panel here

    void Update()
    {
        // Example: toggle menu with Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuUI.activeSelf)
                CloseMenu();
            else
                OpenMenu();
        }
    }

    public void OpenMenu()
    {
        menuUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None; // Unlock the cursor
        Cursor.visible = true;                   // Show cursor
        Time.timeScale = 0f;                     // Pause game
    }

    public void CloseMenu()
    {
        menuUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked; // Lock cursor for FPS
        Cursor.visible = false;                   // Hide cursor
        Time.timeScale = 1f;                      // Resume game
    }
}
