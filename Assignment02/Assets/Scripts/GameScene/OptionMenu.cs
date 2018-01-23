using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour {

    [SerializeField]
    GameObject optionMenu, quitButton;

    [SerializeField]
    GameObject mouseClickSound, gunShotSound, gunReloadSound, coinsSound;

    [SerializeField]
    GameObject backgroundMusic;

    public Slider soundEffects_Slider;
    public Slider backgroundMusic_Slider;
    public Button applyButton;

    private AudioSource mouseClickSource, gunShotSource, gunReloadSource, coinsSource;
    private AudioSource backgroundMusicSource;

	// Use this for initialization
	void Start ()
    {
        mouseClickSource = mouseClickSound.GetComponent<AudioSource>();
        gunShotSource = gunShotSound.GetComponent<AudioSource>();
        gunReloadSource = gunReloadSound.GetComponent<AudioSource>();
        coinsSource = coinsSound.GetComponent<AudioSource>();
        backgroundMusicSource = backgroundMusic.GetComponent<AudioSource>();
        

        soundEffects_Slider.value = PlayerPrefs.GetFloat("sfxVol", 1);
        backgroundMusic_Slider.value = PlayerPrefs.GetFloat("musicVol", 1);
	}

    public void Apply()
    {
        PlayerPrefs.SetFloat("sfxVol", soundEffects_Slider.value);
        PlayerPrefs.SetFloat("musicVol", backgroundMusic_Slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        mouseClickSource.volume = soundEffects_Slider.value;
        gunShotSource.volume = soundEffects_Slider.value;
        gunReloadSource.volume = soundEffects_Slider.value;
        coinsSource.volume = soundEffects_Slider.value;

        backgroundMusicSource.volume = backgroundMusic_Slider.value;
    }

    public void CloseOption()
    {
        soundEffects_Slider.value = PlayerPrefs.GetFloat("sfxVol", 1);
        backgroundMusic_Slider.value = PlayerPrefs.GetFloat("musicVol", 1);

        optionMenu.SetActive(false);
        quitButton.SetActive(true);
    }

}
