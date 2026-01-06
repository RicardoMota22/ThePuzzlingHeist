using UnityEngine;

public class ColliderDisabler : MonoBehaviour
{

    public void DisableCollider()
    {
        BoxCollider[] boxColliders = GetComponents<BoxCollider>();
        foreach(BoxCollider boxCollider in boxColliders)
        {
            boxCollider.enabled = false;
        }
    }
}
