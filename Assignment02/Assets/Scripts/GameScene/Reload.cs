using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

    [SerializeField]
    GameObject soundEffectSound;
    private AudioSource soundEffectSource;

	// Use this for initialization
	void Start(){}
	// Update is called once per frame
	void Update(){}

    public void ReloadCurrBullets()
    {
        soundEffectSource = soundEffectSound.GetComponent<AudioSource>();
        soundEffectSource.volume = PlayerPrefs.GetFloat("sfxVol", 1);

        BulletInventory bullets = GetComponent<BulletInventory>();
        PlayerWeapons weapons = GetComponent<PlayerWeapons>();
        if (Time.timeScale == 0.0f) // if  paused, return
            return;
        
            if (weapons.GetCurrWeaponType() == "Primary")
        {
            // Check if need to reload
            if (bullets.GetPriCurrBullets() < bullets.GetPriMaxBullets())
            { 
                // How many bullets to load
                int BulletsToLoad = bullets.GetPriMaxBullets() - bullets.GetPriCurrBullets();

                if (BulletsToLoad <= bullets.GetPriTotalBullets())
                {
                    soundEffectSource.Play();

                    bullets.SetPriCurrBullets(bullets.GetPriMaxBullets());
                    bullets.AddPriTotalBullets(-BulletsToLoad);
                }
                else
                {
                    soundEffectSource.Play();

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
                    soundEffectSource.Play();

                    bullets.SetSecCurrBullets(bullets.GetSecMaxBullets());
                    bullets.AddSecTotalBullets(-BulletsToLoad);
                }
                else
                {
                    soundEffectSource.Play();

                    bullets.SetSecCurrBullets(bullets.GetSecCurrBullets() + bullets.GetSecTotalBullets());
                    bullets.AddSecTotalBullets(-(bullets.GetSecTotalBullets()));
                }
            }
        }
    }
}
