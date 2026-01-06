using UnityEngine;

public class LaserButtonSound : MonoBehaviour
{
    [SerializeField]private AudioClip buttonPress;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayPressSound()
    {
        audioSource.PlayOneShot(buttonPress);
    }
}
