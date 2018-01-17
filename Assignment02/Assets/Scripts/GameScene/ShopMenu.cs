using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour {

    [SerializeField]
    GameObject shopMenu;

    [SerializeField]
    GameObject category;

    [SerializeField]
    GameObject pistolMenu;

    [SerializeField]
    GameObject rifleMenu;

    [SerializeField]
    GameObject pistol1Info;

    [SerializeField]
    GameObject pistol2Info;

    [SerializeField]
    GameObject rifle1Info;

    [SerializeField]
    GameObject rifle2Info;

    // Use this for initialization
    void Start () {
		
	}
	
    public void CloseShop()
    {
        shopMenu.SetActive(false);
        category.SetActive(true);
        pistolMenu.SetActive(false);
        pistol1Info.SetActive(false);
        pistol2Info.SetActive(false);
        rifleMenu.SetActive(false);
        rifle1Info.SetActive(false);
        rifle2Info.SetActive(false);
    }

    // ============= Pistol Start =============
    public void SelectPistol()
    {
        category.SetActive(false);
        pistolMenu.SetActive(true);
    }

    public void ShowPistol1()
    {
        pistol1Info.SetActive(true);
        pistol2Info.SetActive(false);
    }

    public void ShowPistol2()
    {
        pistol1Info.SetActive(false);
        pistol2Info.SetActive(true);
    }
    // ============= Pistol End =============

    // ============= Rifle Start =============
    public void SelectRifle()
    {
        category.SetActive(false);
        rifleMenu.SetActive(true);
    }

    public void ShowRifle1()
    {
        rifle1Info.SetActive(true);
        rifle2Info.SetActive(false);
    }

    public void ShowRifle2()
    {
        rifle1Info.SetActive(false);
        rifle2Info.SetActive(true);
    }
    // ============= Rifle End =============

    public void BackToCategory()
    {
        category.SetActive(true);
        
        if(pistolMenu.activeInHierarchy)
        {
            pistolMenu.SetActive(false);
            pistol1Info.SetActive(false);
            pistol2Info.SetActive(false);
        }

        if (rifleMenu.activeInHierarchy)
        {
            rifleMenu.SetActive(false);
            rifle1Info.SetActive(false);
            rifle2Info.SetActive(false);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
