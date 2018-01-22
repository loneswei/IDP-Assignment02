using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class OptionScreen : MonoBehaviour {

    [SerializeField]
    GameObject playButton, optionButton;

    [SerializeField]
    GameObject optionScreen, backButton;

    [SerializeField]
    GameObject musicBackground, soundEffects;

    public Button applyButton;

    public Slider musicVolume_Slider;
    public Slider soundEffects_Slider;

    private AudioSource musicSource;
    private AudioSource soundEffectSource;

    void Start()
    {
        musicSource = musicBackground.GetComponent<AudioSource>();
        musicVolume_Slider.value = PlayerPrefs.GetFloat("musicVol", 1);

        soundEffectSource = soundEffects.GetComponent<AudioSource>();
        soundEffects_Slider.value = PlayerPrefs.GetFloat("sfxVol", 1);
    }

    void Update()
    {
        musicSource.volume = musicVolume_Slider.value;
        soundEffectSource.volume = soundEffects_Slider.value;
    }

    public void Apply()
    {
        PlayerPrefs.SetFloat("musicVol", musicVolume_Slider.value);
        PlayerPrefs.SetFloat("sfxVol", soundEffects_Slider.value);
    }

    public void Back()
    {
        musicVolume_Slider.value = PlayerPrefs.GetFloat("musicVol", 1);
        soundEffects_Slider.value = PlayerPrefs.GetFloat("sfxVol", 1);

        playButton.SetActive(true);
        optionButton.SetActive(true);
        optionScreen.SetActive(false);
    }
}
