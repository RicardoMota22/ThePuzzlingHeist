using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FadeToVictoryScene : MonoBehaviour
{
    [SerializeField] private CanvasGroup fadeCanvas;
    private float fadeDuration = 1f;
    private string victorySceneName = "VictoryScene";

    private bool isFading;

    public void TriggerVictory()
    {
        if(!isFading)
        {
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        isFading = true;

        float t = 0f;

        while(t < fadeDuration)
        {
            t += Time.deltaTime;
            fadeCanvas.alpha = t /fadeDuration;
            yield return null;
        }

        SceneManager.LoadScene(victorySceneName);
    }
}
