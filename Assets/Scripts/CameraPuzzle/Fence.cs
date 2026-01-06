using UnityEngine;

public class Fence : MonoBehaviour
{
    MeshRenderer[] meshRenderers;
    void Awake()
    {
        meshRenderers = GetComponentsInChildren<MeshRenderer>();
    }
    public void RemoveFence()
    {
        foreach(MeshRenderer meshRenderer in meshRenderers)
        {
            meshRenderer.enabled = false;
        }

        BoxCollider[] boxColliders = GetComponents<BoxCollider>();
        foreach(BoxCollider boxCollider in boxColliders)
        {
            boxCollider.enabled = false;
        }
    }
}
