using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    [SerializeField]
    GameObject pauseButton;

    [SerializeField]
    GameObject pauseMenu;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Pause()
    {
        pauseButton.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
