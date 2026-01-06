using System.Linq;
using UnityEngine;

public class InsertedCode : MonoBehaviour
{
    private int[] codeNumbers = new int[3];
    private int[] correctCode = new int[] { 3, 1, 5 };
    private int currentIndex = 0;
    private bool isCorrect = false;
    private bool isComplete = false;
    Interactive interactive;

    void Start()
    {
        interactive = GetComponent<Interactive>();

        interactive.interactiveData.requirementsMessage = "";
    }

    void Update()
    {
        isComplete = IsComplete();
        if(isComplete)
        {
            isCorrect = CheckCode();

            if(isCorrect)
            {
                interactive.FulfillRequirements();
                interactive.TriggerIndirect();
            }
            else if(!isCorrect)
            {
                codeNumbers = new int[3];
                interactive.interactiveData.requirementsMessage = "";
                isComplete = false;
                currentIndex = 0;
            }
        }
    }

    public void InsertNumber(int codeNumber)
    {
        codeNumbers[currentIndex] = codeNumber;
        currentIndex++;

        interactive.interactiveData.requirementsMessage = GetCodeAsString();
    }

    private string GetCodeAsString()
    {
        string result = "";

        for(int i = 0; i < currentIndex; i++)
        {
            result += codeNumbers[i] + " ";
        }
        return result;
    }
    public bool IsComplete()
    {
        return currentIndex == codeNumbers.Length;
    }

    public bool CheckCode()
    {
        return codeNumbers.SequenceEqual(correctCode);
    }
}
