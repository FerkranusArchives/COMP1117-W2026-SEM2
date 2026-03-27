using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] public GameObject pauseMenu;
    [SerializeField] public GameObject MainMenu;

    public void StartGame()
    {
        AudioManager.Instance.PlayLevelMusic();
        SceneManager.LoadScene("Level");
    }

    public void Options()
    {
        pauseMenu.SetActive(true);
       MainMenu.SetActive(false);
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
