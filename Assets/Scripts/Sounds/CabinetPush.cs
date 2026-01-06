using UnityEngine;

public class CabinetPush : MonoBehaviour
{
    [SerializeField] private AudioClip cabinetPush;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayPushSound()
    {
        audioSource.PlayOneShot(cabinetPush);
    }
}
