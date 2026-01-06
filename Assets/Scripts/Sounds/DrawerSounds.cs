using UnityEngine;

public class DrawerSounds : MonoBehaviour
{
    [SerializeField]private AudioClip openSound;
    [SerializeField]private AudioClip closeSound;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayOpenSound()
    {
        audioSource.PlayOneShot(openSound);
    }
    public void PlayCloseSound()
    {
        audioSource.PlayOneShot(closeSound);
    }
}
