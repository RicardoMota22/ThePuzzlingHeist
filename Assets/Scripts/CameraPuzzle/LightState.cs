using UnityEngine;

public class LightState : MonoBehaviour
{
    [SerializeField] private GameObject connectedSwitch;
    private SwitchState switchState;
    private MeshRenderer lightColor;
    void Awake()
    {
        lightColor = GetComponent<MeshRenderer>();
        switchState = connectedSwitch.GetComponent<SwitchState>();
    }

    void OnEnable()
    {
        switchState.OnToggled += LightChange;
    }

    void OnDisable()
    {
        switchState.OnToggled -= LightChange;
    }

    public void LightChange(int switchStatus)
    {
        if(switchStatus == 1)
        {
            lightColor.material = Resources.Load("Green",typeof(Material)) as Material;
        }
        else if(switchStatus == 0)
        {
            lightColor.material = Resources.Load("Red",typeof(Material)) as Material;
        }
    }
}
