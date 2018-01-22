using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

	// Use this for initialization
	void Start(){}
	// Update is called once per frame
	void Update(){}

    public void ReloadCurrBullets()
    {
        BulletInventory bullets = GetComponent<BulletInventory>();
        PlayerWeapons weapons = GetComponent<PlayerWeapons>();

        if (weapons.GetCurrWeaponType() == "Primary")
        {
            // Check if need to reload
            if (bullets.GetPriCurrBullets() < bullets.GetPriMaxBullets())
            { 
                // How many bullets to load
                int BulletsToLoad = bullets.GetPriMaxBullets() - bullets.GetPriCurrBullets();

                if (BulletsToLoad <= bullets.GetPriTotalBullets())
                {
                    bullets.SetPriCurrBullets(bullets.GetPriMaxBullets());
                    bullets.AddPriTotalBullets(-BulletsToLoad);
                }
                else
                {
                    bullets.SetPriCurrBullets(bullets.GetPriCurrBullets() + bullets.GetPriTotalBullets());
                    bullets.AddPriTotalBullets(-(bullets.GetPriTotalBullets()));
                }
            }
        }
        else if (weapons.GetCurrWeaponType() == "Secondary")
        {
            // Check if need to reload
            if (bullets.GetSecCurrBullets() < bullets.GetSecMaxBullets())
            {
                // How many bullets to load
                int BulletsToLoad = bullets.GetSecMaxBullets() - bullets.GetSecCurrBullets();

                if (BulletsToLoad <= bullets.GetSecTotalBullets())
                {
                    bullets.SetSecCurrBullets(bullets.GetSecMaxBullets());
                    bullets.AddSecTotalBullets(-BulletsToLoad);
                }
                else
                {
                    bullets.SetSecCurrBullets(bullets.GetSecCurrBullets() + bullets.GetSecTotalBullets());
                    bullets.AddSecTotalBullets(-(bullets.GetSecTotalBullets()));
                }
            }
        }
    }
}
