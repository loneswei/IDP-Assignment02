using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionScreen : MonoBehaviour {

    [SerializeField]
    GameObject playButton, optionButton;

    [SerializeField]
    GameObject optionScreen;

    public AudioSource soundEffectsSource;
    public Slider soundEffectsVolume_Slider;
    OptionSettings optionSettings;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Back()
    {
        playButton.SetActive(true);
        optionButton.SetActive(true);
        optionScreen.SetActive(false);
    }

    public void OnEnable()
    {
        optionSettings = new OptionSettings();

        soundEffectsVolume_Slider.onValueChanged.AddListener(delegate { SoundEffectsVolumeChange(); });
    }

    public void SoundEffectsVolumeChange()
    {
        soundEffectsSource.volume = optionSettings.soundEffects_Volume = soundEffectsVolume_Slider.value;
    }

    public void SaveSettings()
    {

    }

    public void LoadSettings()
    {

    }

	// Update is called once per frame
	void Update () {
		
	}
}
