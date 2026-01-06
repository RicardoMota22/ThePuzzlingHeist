using System;
using UnityEngine;

public class ButtonState : MonoBehaviour
{
    [SerializeField][Range(0,7)] private int buttonSetting = 0;
    public int ButtonSetting
    {
        get {return buttonSetting;}
        set
        {
            buttonSetting = value;
        }
    }
    public static event Action<ButtonState> OnAnyToggled;
    private MeshRenderer meshRenderer;
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    public void OnInteract()
    {
        Toggle();
    }

    public void Toggle()
    {
        buttonSetting++;
        if(buttonSetting > 6)
        {
            buttonSetting = 0;
        }
        meshRenderer.material = ColorChange(buttonSetting);
        OnAnyToggled?.Invoke(this);
    }

    public Material ColorChange(int setting)
    {
        Material red = Resources.Load("Red",typeof(Material)) as Material;
        Material yellow = Resources.Load("Yellow",typeof(Material)) as Material;
        Material blue = Resources.Load("Blue",typeof(Material)) as Material;
        Material green = Resources.Load("Green",typeof(Material)) as Material;
        Material purple = Resources.Load("Purple",typeof(Material)) as Material;
        Material orange = Resources.Load("Orange",typeof(Material)) as Material;
        Material code = Resources.Load("Code",typeof(Material)) as Material;

        return setting switch
        {
            1 => red,
            2 => yellow,
            3 => blue,
            4 => green,
            5 => purple,
            6 => orange,
            0 => code,
            _ => null,
        };
    }
}
