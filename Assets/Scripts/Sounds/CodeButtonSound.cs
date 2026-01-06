using UnityEngine;

public class CodeButtonSound : MonoBehaviour
{
    [SerializeField] private AudioClip buttonPress;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayButtonPressSound()
    {
        audioSource.PlayOneShot(buttonPress);
    }
}
