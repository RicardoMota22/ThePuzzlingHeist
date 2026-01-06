using UnityEngine;

public class ShowBookContent : MonoBehaviour
{
    [SerializeField] private GameObject bookContent;
    [SerializeField] private Animator contentAnimator;
    [SerializeField] private AudioClip openBook;
    [SerializeField] private AudioClip closeBook;
    private AudioSource audioSource;
    private bool bookOpen = false;

    public static bool isReading = false;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void Start()
    {
        bookContent.SetActive(false);
    }

    public void ShowContentBook()
    {
        audioSource.PlayOneShot(openBook);
        bookContent.SetActive(true);
        bookOpen = true;
        isReading = true;
    }

    void Update()
    {
        if(Input.GetButtonDown("Interact") && bookOpen)
        {
            audioSource.PlayOneShot(closeBook);
            bookContent.SetActive(false);
            bookOpen = false;
            contentAnimator.SetTrigger("Close Content");
            isReading = false;
        }
    }
}
