using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour {

    [SerializeField]
    GameObject optionMenu, quitButton;

	// Use this for initialization
	void Start () {
		
	}
	
    public void CloseOption()
    {
        optionMenu.SetActive(false);
        quitButton.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
