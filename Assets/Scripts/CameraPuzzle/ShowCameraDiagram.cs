using UnityEngine;

public class ShowCameraDiagram : MonoBehaviour
{
    [SerializeField] private GameObject cameraDiagram;
    [SerializeField] private Animator diagramAnimator;
    private bool diagramOpen = false;

    void Start()
    {
        cameraDiagram.SetActive(false);
    } 

    public void ShowDiagramCamera()
    {
        cameraDiagram.SetActive(true);
        diagramOpen = true;
        ShowBookContent.isReading = true;
    }

    void Update()
    {
        if(Input.GetButtonDown("Interact") && diagramOpen)
        {
            ShowBookContent.isReading = false;
            cameraDiagram.SetActive(false);
            diagramOpen = false;
            diagramAnimator.SetTrigger("CloseDiagram");
        }
    }
}
