using UnityEngine;

public class LaserShutdown : MonoBehaviour
{
    MeshRenderer[] meshRenderers;
    void Awake()
    {
        meshRenderers = GetComponentsInChildren<MeshRenderer>();
    }

    public void ShutdownLasers()
    {
        BoxCollider[] boxColliders = GetComponents<BoxCollider>();
        foreach(BoxCollider boxCollider in boxColliders)
        {
            boxCollider.enabled = false;
        }

        foreach(MeshRenderer meshRenderer in meshRenderers)
        {
            meshRenderer.enabled = false;
        }
    }
}
