using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //BulletInventory bullets = GetComponent<BulletInventory>();
        //if (bullets.GetCurrMag() <= 0)
        //{
        //    ReloadCurrMag();
        //}
    }

    public void ReloadCurrMag()
    {
        BulletInventory bullets = GetComponent<BulletInventory>();
        PlayerWeapons weapons = GetComponent<PlayerWeapons>();

        if (weapons.GetCurrWeaponType() == "Primary")
        {
            if (bullets.GetPriCurrMag() < bullets.GetPriMaxMag())
            {
                int temp = bullets.GetPriMaxMag() - bullets.GetPriCurrMag(); // how many bullets to load into magazine

                if (temp <= bullets.GetPriAmmoStore())
                {
                    bullets.SetPriCurrMag(bullets.GetPriMaxMag());
                    bullets.AddPriAmmoStore(-temp);
                }

                else if (temp > bullets.GetPriAmmoStore())
                {
                    bullets.SetPriCurrMag(bullets.GetPriCurrMag() + bullets.GetPriAmmoStore());
                    bullets.AddPriAmmoStore(-(bullets.GetPriAmmoStore()));
                }
            }
        }

        else if (weapons.GetCurrWeaponType() == "Secondary")
        {
            if (bullets.GetSecCurrMag() < bullets.GetSecMaxMag())
            {
                int temp = bullets.GetSecMaxMag() - bullets.GetSecCurrMag(); // how many bullets to load into magazine

                if (temp <= bullets.GetSecAmmoStore())
                {
                    bullets.SetSecCurrMag(bullets.GetSecMaxMag());
                    bullets.AddSecAmmoStore(-temp);
                }

                else if (temp > bullets.GetSecAmmoStore())
                {
                    bullets.SetSecCurrMag(bullets.GetSecCurrMag() + bullets.GetSecAmmoStore());
                    bullets.AddSecAmmoStore(-(bullets.GetSecAmmoStore()));
                }
            }
        }

    }
}
