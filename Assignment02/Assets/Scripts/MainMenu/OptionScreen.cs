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

    public Slider soundEffectsVolume_Slider;
    public Slider musicVolume_Slider;

    private AudioSource musicSource;

    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        musicVolume_Slider.value = PlayerPrefs.GetFloat("musicVol", 1);
    }

    void Update()
    {
        musicSource.volume = musicVolume_Slider.value;
    }

    public void Apply()
    {
        PlayerPrefs.SetFloat("musicVol", musicVolume_Slider.value);
        Debug.Log("Saved");
    }

    public void Back()
    {
        playButton.SetActive(true);
        optionButton.SetActive(true);
        optionScreen.SetActive(false);
    }
}
