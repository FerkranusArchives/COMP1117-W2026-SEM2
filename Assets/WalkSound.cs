using UnityEngine;

public class WalkSound : MonoBehaviour
{
    public void OnWalk()
    {
        AudioManager.Instance.PlayWalkSFX();
    }
}
