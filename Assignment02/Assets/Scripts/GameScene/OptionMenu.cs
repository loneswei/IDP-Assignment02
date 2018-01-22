using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour {

    [SerializeField]
    GameObject optionMenu, quitButton;

    [SerializeField]
    GameObject gunShotSound/*, gunReloadSound*/;

    public Slider soundEffects_Slider;
    public Button applyButton;

    private AudioSource gunShotSource/*, gunReloadSource*/;
    private float volume;

	// Use this for initialization
	void Start ()
    {
        gunShotSource = gunShotSound.GetComponent<AudioSource>();
        //gunReloadSource = gunReloadSound.GetComponent<AudioSource>();

        soundEffects_Slider.value = PlayerPrefs.GetFloat("sfxVol", 1); ;
	}

    public void Apply()
    {
        PlayerPrefs.SetFloat("sfxVol", soundEffects_Slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        gunShotSource.volume = soundEffects_Slider.value;
        //gunReloadSource.volume = soundEffects_Slider.value;
    }

    public void CloseOption()
    {
        soundEffects_Slider.value = PlayerPrefs.GetFloat("sfxVol", 1);

        optionMenu.SetActive(false);
        quitButton.SetActive(true);
    }

}
