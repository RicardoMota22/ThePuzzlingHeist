using UnityEngine;

public class CameraSwitchSound : MonoBehaviour
{
    [SerializeField] private AudioClip offSound;
    [SerializeField] private AudioClip onSound;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayOffSound()
    {
        audioSource.PlayOneShot(offSound);
    }
    public void PlayOnSound()
    {
        audioSource.PlayOneShot(onSound);
    }
}
