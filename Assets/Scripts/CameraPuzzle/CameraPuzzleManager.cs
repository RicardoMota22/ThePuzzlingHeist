using System.Linq;
using UnityEngine;

[RequireComponent(typeof(Interactive))]
public class CameraPuzzleManager : MonoBehaviour
{
    public GameObject[] combination;
    public int[] correctCombination = {0,0,1,1,1,1,0,1};

    private Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void OnEnable()
    {
        SwitchState.OnAnyToggled += CheckCombination;
    }

    void OnDisable()
    {
        SwitchState.OnAnyToggled -= CheckCombination;
    }

    public void CheckCombination(SwitchState _)
    {
        int[] currentCombination = new int[combination.Length];

        for(int i = 0; i < combination.Length; i++)
        {
            SwitchState ss = combination[i].GetComponent<SwitchState>();
            currentCombination[i] = ss.SwitchSetting;
        }

        if(currentCombination.SequenceEqual(correctCombination))
        {
            Interactive interactive = GetComponent<Interactive>();
            interactive.FulfillRequirements();
            interactive.TriggerIndirect();
        }
    }
}
