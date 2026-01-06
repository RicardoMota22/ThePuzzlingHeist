using UnityEngine;

public class PanelDoorOpening : MonoBehaviour
{
    [SerializeField] private AudioClip openDoor;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayOpenDoorSound()
    {
        audioSource.PlayOneShot(openDoor);
    }
}
