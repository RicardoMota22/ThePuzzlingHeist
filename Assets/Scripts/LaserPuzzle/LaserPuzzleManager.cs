using System.Linq;
using UnityEngine;

public class LaserPuzzleManager : MonoBehaviour
{
    public GameObject[] configuration;
    public int[] correctConfiguration = {3,1,6,4,2,5};
    private Animator animator;
    
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.L))
        {
            for(int i = 0; i < configuration.Length; i++)
            {
                configuration[i].GetComponent<ButtonState>().ButtonSetting = correctConfiguration[i];
            }
            CheckConfiguration(null);
        }
    }

    void OnEnable()
    {
        ButtonState.OnAnyToggled += CheckConfiguration;
    }
    void OnDisable()
    {
        ButtonState.OnAnyToggled -= CheckConfiguration;
    }

    public void CheckConfiguration(ButtonState _)
    {
        int[] currentConfiguration = new int[configuration.Length];

        for(int i = 0; i < configuration.Length; i++)
        {
            ButtonState bs = configuration[i].GetComponent<ButtonState>();
            currentConfiguration[i] = bs.ButtonSetting;
        }

        if(currentConfiguration.SequenceEqual(correctConfiguration))
        {
            Interactive interactive = GetComponent<Interactive>();
            interactive.FulfillRequirements();
            interactive.TriggerIndirect();
        }
    }
}
