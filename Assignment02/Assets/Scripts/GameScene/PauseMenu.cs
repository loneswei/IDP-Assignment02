using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    [SerializeField]
    GameObject pauseButton;

    [SerializeField]
    GameObject pauseMenu;

    [SerializeField]
    GameObject shopMenu;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void OpenShop() { shopMenu.SetActive(true); }

	// Update is called once per frame
	void Update () {
		
	}
}
