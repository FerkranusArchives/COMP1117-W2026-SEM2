using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public AudioClip levelMusic;

    public void StartGame()
    {
        AudioManager.Instance.PlayMusic(levelMusic);
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        // Pre-processor Directives
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
