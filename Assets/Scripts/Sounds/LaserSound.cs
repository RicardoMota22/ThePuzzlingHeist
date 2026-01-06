using UnityEngine;

public class LaserSound : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
    }

    public void OnEnable()
    {
        audioSource.Play();
    }

    public void OnDisable()
    {
        audioSource.Stop();
    }
}
