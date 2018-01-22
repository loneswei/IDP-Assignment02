using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionSelectDetails : MonoBehaviour {

    [SerializeField]
    GameObject levelOneDetails, levelOneScreen, acceptButton, declineButton, levelOneButton;

	// Use this for initialization
	void Start ()
    {
        levelOneButton.SetActive(false);
    }
	
    public void Decline()
    {
        levelOneDetails.SetActive(false);
        levelOneScreen.SetActive(false);
        acceptButton.SetActive(false);
        declineButton.SetActive(false);
        levelOneButton.SetActive(true);
    }

    public void Accept()
    {
        SceneManager.LoadSceneAsync("GameScene");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
