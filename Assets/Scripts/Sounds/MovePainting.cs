using UnityEngine;

public class MovePainting : MonoBehaviour
{
    [SerializeField] private AudioClip movePainting;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayMovePaintingSound()
    {
        audioSource.PlayOneShot(movePainting);
    }
}
