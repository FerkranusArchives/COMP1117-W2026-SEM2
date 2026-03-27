using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseMenuControl : MonoBehaviour
{
    [Header ("Sliders")]
    [SerializeField] public Slider MasterSlider;
    [SerializeField] public Slider SFXSlider;
    [SerializeField] public Slider MusicSlider;

    [Header("Mixer")]
    [SerializeField] public AudioMixer mixer;

    [Header("Values")]
    [SerializeField] public float MasterVal;
    [SerializeField] public float SFXVal;
    [SerializeField] public float MusicVal;

    [Header("Menus")]
    [SerializeField] public GameObject MainMenu;
    [SerializeField] public GameObject PauseMenu;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void OnMasterChange()
    {
       MasterSlider.value = MasterVal;
        mixer.SetFloat("MasterVolume", MasterVal);
    }

    public void OnSFXChange()
    {
        SFXSlider.value = SFXVal;
        mixer.SetFloat("SFXVolume", SFXVal);
    }

    public void OnMusicChange()
    {
        MusicSlider.value = MusicVal;
        mixer.SetFloat("MusicVolume", MusicVal);
    }

    public void OnBack()
    {
        MainMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }
}
