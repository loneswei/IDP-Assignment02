using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour {

    [SerializeField]
    GameObject shopMenu;

	// Use this for initialization
	void Start () {
		
	}
	
    public void Back()
    {
        shopMenu.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
