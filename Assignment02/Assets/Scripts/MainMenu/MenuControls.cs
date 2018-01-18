using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour {

    [SerializeField]
    GameObject playButton, missionSelectScreen;

    [SerializeField]
    GameObject optionButton, optionScreen;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Play()
    {
        playButton.SetActive(false);
        optionButton.SetActive(false);
        missionSelectScreen.SetActive(true);
    }

    public void Option()
    {
        playButton.SetActive(false);
        optionButton.SetActive(false);
        optionScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
