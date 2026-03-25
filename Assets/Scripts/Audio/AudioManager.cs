using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Singleton Pattern
    // 1. Static access point
    public static AudioManager Instance;

    [Header("Music")]
    [Tooltip("Playing looping background tracks")]
    [SerializeField] private AudioSource musicSource;

    [Header("SFX")]
    [Tooltip("Plays one-shot sound effects")]
    [SerializeField] private AudioSource sfxSource;

    private void Awake()
    {
        // Singleton Pattern Logic
        // 2. Create the reference to the instance, if it hasn't been created yet!
        if(Instance == null)
        {
            // I'm the first one, I am THE instance
            Instance = this;

            // Persist this across scenes. 
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If another audiomanager is trying to be created, destroy it.
            Destroy(gameObject);
        }
    }

    public void PlayMusic(AudioClip musicClip, bool isLooping = true)
    {
        musicSource.clip = musicClip;
        musicSource.loop = isLooping;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
}
