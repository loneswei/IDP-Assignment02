using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionScreen : MonoBehaviour {

    [SerializeField]
    GameObject playButton, optionButton;

    [SerializeField]
    GameObject optionScreen;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Back()
    {
        playButton.SetActive(true);
        optionButton.SetActive(true);
        optionScreen.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
