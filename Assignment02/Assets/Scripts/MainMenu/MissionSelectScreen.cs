using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionSelectScreen : MonoBehaviour {

    [SerializeField]
    GameObject playButton, optionButton, missionSelectScreen;

    [SerializeField]
    GameObject levelOneDetails, levelOneDetailsScreen, acceptButton, declineButton;

    // Use this for initialization
    void Start () {
		
	}
	
    public void Back()
    {
        playButton.SetActive(true);
        optionButton.SetActive(true);
        missionSelectScreen.SetActive(false);
    }

    public void LevelOneDetails()
    {
        levelOneDetails.SetActive(true);
        levelOneDetailsScreen.SetActive(true);
        acceptButton.SetActive(true);
        declineButton.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
