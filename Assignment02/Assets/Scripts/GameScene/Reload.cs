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

        if (bullets.GetCurrMag() <= 0)
        {
            if (bullets.GetMaxMag() <= bullets.GetAmmoStore())
            {
                bullets.SetCurrMag(bullets.GetMaxMag());
                bullets.AddAmmoStore(-(bullets.GetMaxMag()));
            }

            else if (bullets.GetMaxMag() > bullets.GetAmmoStore())
            {
                int temp = bullets.GetAmmoStore();

                bullets.SetCurrMag(bullets.GetAmmoStore());
                bullets.AddAmmoStore(-(bullets.GetAmmoStore()));
            }
        }
    }
}
