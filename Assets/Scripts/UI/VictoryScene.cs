using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{
    private string mainMenuScene = "MainMenu";

    void Update()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene(mainMenuScene);
        }
    }
}
