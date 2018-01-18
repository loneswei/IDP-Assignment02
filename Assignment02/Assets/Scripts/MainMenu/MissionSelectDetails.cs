using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionSelectDetails : MonoBehaviour {

    [SerializeField]
    GameObject levelOneDetails;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Decline()
    {
        levelOneDetails.SetActive(false);
    }

    public void Accept()
    {
        // SceneManager.LoadSceneAsync("GameScene");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
