using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMenu : MonoBehaviour {

    [SerializeField]
    GameObject confirmationQuitScreen;

	// Use this for initialization
	void Start () {
		
	}
	
    public void No()
    {
        confirmationQuitScreen.SetActive(false);
    }

    public void Yes()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
