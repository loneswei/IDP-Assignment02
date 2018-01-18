using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControls : MonoBehaviour {

    [SerializeField]
    GameObject playButton, missionSelectScreen;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Play()
    {
        playButton.SetActive(false);
        missionSelectScreen.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
