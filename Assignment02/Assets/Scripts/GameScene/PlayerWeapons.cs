using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWeapons : MonoBehaviour {

    int cash = 600;
    [SerializeField]
    Text cashText;

    string primaryWeapon = "None";
    string secondaryWeapon = "228 Compact";
    string currWepType;

    // Use this for initialization
    void Start() { currWepType = "Secondary"; }
	// Update is called once per frame
	void Update(){ cashText.text = "$ " + cash; }
    
    public int GetCash() { return cash; }
    public void AddCash(int _cash)
    {
        if (cash + _cash < 0)
            cash = 0;
        else
            cash += _cash;
    }

    public string GetCurrWeaponType() { return currWepType; }
    public string GetPriWeapon() { return primaryWeapon; }
    public void SetPriWeapon(string PriWeapon)
    {
        if (primaryWeapon != "None" && primaryWeapon == PriWeapon)
            return;
        else
        {
            primaryWeapon = PriWeapon;
            if (primaryWeapon == "AK-47" || primaryWeapon == "M4A1")
            {
                BulletInventory bullets = GetComponent<BulletInventory>();
                bullets.SetPriCurrBullets(30);
                bullets.SetPriTotalBullets(0);
                bullets.SetPriMaxBullets(30);
                bullets.SetPriMaxTotalBullets(90);
            }
        }
    }
    public string GetSecWeapon() { return secondaryWeapon; }
    public void SetSecWeapon(string SecWeapon)
    {
        if (secondaryWeapon == SecWeapon)
            return;
        else
        {
            secondaryWeapon = SecWeapon;
            BulletInventory bullets = GetComponent<BulletInventory>();
            if(secondaryWeapon == "228 Compact")
            {
                bullets.SetSecCurrBullets(13);
                bullets.SetSecMaxBullets(13);
                bullets.SetSecTotalBullets(13);
                bullets.SetSecMaxTotalBullets(52);
            }
            else if(secondaryWeapon == "Desert Eagle")
            {
                bullets.SetSecCurrBullets(7);
                bullets.SetSecMaxBullets(7);
                bullets.SetSecTotalBullets(14);
                bullets.SetSecMaxTotalBullets(35);
            }
        }
    }

    public void Switch()
    {
        if (currWepType == "Secondary")
        {
            if (primaryWeapon != "None")
                currWepType = "Primary";
        }
        else if (currWepType == "Primary")
        {
            if (secondaryWeapon != "None")
                currWepType = "Secondary";
        }
    }
}
