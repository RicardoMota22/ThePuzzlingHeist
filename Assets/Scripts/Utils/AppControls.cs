using UnityEngine;

public class AppControls : MonoBehaviour
{
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
        */
    }

    void Quit()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

    }
}
