using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class OptionScreen : MonoBehaviour {

    [SerializeField]
    GameObject playButton, optionButton;

    [SerializeField]
    GameObject optionScreen;

    public Button applyButton;

    public Slider musicVolume_Slider;
    public Slider soundEffects_Slider;

    public AudioSource musicSource;
    public AudioSource soundEffectSource;

    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        musicVolume_Slider.value = PlayerPrefs.GetFloat("musicVol", 1);

        soundEffectSource = GetComponent<AudioSource>();
        soundEffects_Slider.value = PlayerPrefs.GetFloat("sfxVol", 1);
    }

    void Update()
    {
        musicSource.volume = musicVolume_Slider.value;
        soundEffectSource.volume = soundEffects_Slider.value;
    }

    public void PlayOnce()
    {
        soundEffectSource.volume = soundEffects_Slider.value;
        soundEffectSource.Play();
    }

    public void Apply()
    {
        PlayerPrefs.SetFloat("musicVol", musicVolume_Slider.value);
        PlayerPrefs.SetFloat("sfxVol", soundEffects_Slider.value);
    }

    public void Back()
    {
        playButton.SetActive(true);
        optionButton.SetActive(true);
        optionScreen.SetActive(false);
    }
}
