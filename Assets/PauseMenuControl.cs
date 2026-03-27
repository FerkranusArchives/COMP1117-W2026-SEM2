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

    //[Header("Values")]
    //public float MasterVal;
    //public float SFXVal;
    //public float MusicVal;
   // [SerializeField] public float MasterVal;
    //[SerializeField] public float SFXVal;
   // [SerializeField] public float MusicVal;

    [Header("Menus")]
    [SerializeField] public GameObject MainMenu;
    [SerializeField] public GameObject PauseMenu;



    
    public void OnMasterChange()
    {
        mixer.SetFloat("MasterVolume", MasterSlider.value);
    }

    public void OnSFXChange()
    {
        mixer.SetFloat("SFXVolume", SFXSlider.value);
    }

    public void OnMusicChange()
    {
        mixer.SetFloat("MusicVolume", MusicSlider.value);
    }

    public void OnBack()
    {
        MainMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }
}
