using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteFail_ScreenMenu : MonoBehaviour {


    [SerializeField]
    GameObject quitButton;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Quit()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadSceneAsync("MainMenu");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
