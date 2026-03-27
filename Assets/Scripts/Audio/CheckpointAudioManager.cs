using UnityEngine;

public class CheckpointAudioManager : MonoBehaviour
{
    [SerializeField] public Checkpoint checkpointRef;
    [SerializeField] private AudioSource sfxSource;
    public AudioClip checkpoint;


    public void PlayCheckpointSFX() => sfxSource.PlayOneShot(checkpoint);

    private void OnEnable()
    {
        checkpointRef.OnCheckpointReached += PlayCheckpointSFX;
    }

    private void OnDisable()
    {
        if (checkpointRef != null)
        {
            checkpointRef.OnCheckpointReached -= PlayCheckpointSFX;
        }
    }
}
