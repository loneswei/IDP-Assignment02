using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    [SerializeField]
    GameObject pauseButton;

    [SerializeField]
    GameObject pauseMenu, optionButton, quitButton;

    [SerializeField]
    GameObject shopMenu;

    [SerializeField]
    GameObject optionMenu;

    [SerializeField]
    GameObject confirmationQuitScreen;

    bool isPaused = false;

	// Use this for initialization
	void Start () {
		
	}

    public void Pause()
    {
        pauseButton.SetActive(false);
        pauseMenu.SetActive(true);
        isPaused = true;
        Time.timeScale = 0.0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        isPaused = false;
        Time.timeScale = 1.0f;
    }

    public void OpenShop()
    {
        shopMenu.SetActive(true);
        optionButton.SetActive(false);
        quitButton.SetActive(false);
    }

    public void OpenOption()
    {
        optionMenu.SetActive(true);
        quitButton.SetActive(false);
    }

    public void OpenConfirmationQuitScreen()
    {
        confirmationQuitScreen.SetActive(true);
    }

    public bool CheckIsPaused()
    {
        return isPaused;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
