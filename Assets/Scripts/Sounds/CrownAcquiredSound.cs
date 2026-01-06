using UnityEngine;

public class CrownAcquiredSound : MonoBehaviour
{
    [SerializeField] private AudioClip crownAcquired;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayCrownAcquiredSound()
    {
        audioSource.PlayOneShot(crownAcquired);
    }
}
