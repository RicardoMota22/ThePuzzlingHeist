using System;
using UnityEngine;
using UnityEngine.UI;

public class SwitchState : MonoBehaviour
{
    [SerializeField][Range(0,1)] private int switchSetting = 1;
    public int SwitchSetting => switchSetting;
    public static event Action<SwitchState> OnAnyToggled;
    public event Action<int> OnToggled;

    public void OnInteractAnimation()
    {
        Toggle();
    }

    public void Toggle()
    {
        switchSetting = 1 - switchSetting;

        OnToggled?.Invoke(switchSetting);
        OnAnyToggled?.Invoke(this);
    }
}
