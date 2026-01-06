using UnityEngine;

public class TriggerEndLevel : MonoBehaviour
{
    [SerializeField] private FadeToVictoryScene fadeToVictoryScene;
    public void TriggerEnd()
    {
        fadeToVictoryScene.TriggerVictory();
    }
}
