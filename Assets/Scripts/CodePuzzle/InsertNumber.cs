using UnityEngine;

public class InsertNumber : MonoBehaviour
{
    [SerializeField]NumberButtons numberButtons;
    [SerializeField]InsertedCode insertedCode;
    void OnInteract()
    {
        insertedCode.InsertNumber(numberButtons.buttonNumber);
    }
}
