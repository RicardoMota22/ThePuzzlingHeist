using UnityEngine;

public class CaseOpen : MonoBehaviour
{
    MeshRenderer meshRenderer;
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    public void OpenCase()
    {
        meshRenderer.enabled = false;

        BoxCollider[] boxColliders = GetComponents<BoxCollider>();
        foreach(BoxCollider boxCollider in boxColliders)
        {
            boxCollider.enabled = false;
        }
    }

    
}
