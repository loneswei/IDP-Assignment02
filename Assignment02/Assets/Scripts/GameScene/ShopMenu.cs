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

    [SerializeField]
    GameObject optionButton, quitButton;

    [SerializeField]
    GameObject playerWeapon;

    // Use this for initialization
    void Start(){}
    // Update is called once per frame
    void Update(){}

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

        optionButton.SetActive(true);
        quitButton.SetActive(true);
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

    public void BuyPistol1()
    {
        PlayerWeapons weapon = playerWeapon.GetComponent<PlayerWeapons>();
        if(weapon.GetCash() - 100 >= 0)
        {
            weapon.AddCash(-100);
            weapon.SetSecWeapon("228 Compact");
        }
    }

    public void ShowPistol2()
    {
        pistol1Info.SetActive(false);
        pistol2Info.SetActive(true);
    }

    public void BuyPistol2()
    {
        PlayerWeapons weapon = playerWeapon.GetComponent<PlayerWeapons>();
        if (weapon.GetCash() - 200 >= 0)
        {
            weapon.AddCash(-200);
            weapon.SetSecWeapon("Desert Eagle");
        }
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

    public void BuyRifle1()
    {
        PlayerWeapons weapon = playerWeapon.GetComponent<PlayerWeapons>();
        if (weapon.GetCash() - 600 >= 0)
        {
            weapon.AddCash(-600);
            weapon.SetPriWeapon("AK-47");
        }
    }

    public void ShowRifle2()
    {
        rifle1Info.SetActive(false);
        rifle2Info.SetActive(true);
    }

    public void BuyRifle2()
    {
        PlayerWeapons weapon = playerWeapon.GetComponent<PlayerWeapons>();
        if (weapon.GetCash() - 700 >= 0)
        {
            weapon.AddCash(-700);
            weapon.SetPriWeapon("M4A1");
        }
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

    public void BuyPriAmmo()
    {
        PlayerWeapons weapon = playerWeapon.GetComponent<PlayerWeapons>();
        BulletInventory bullets = playerWeapon.GetComponent<BulletInventory>();
        if(bullets.GetPriTotalBullets() < bullets.GetPriMaxTotalBullets())
        {
            int BulletsToBuy = bullets.GetPriMaxTotalBullets() - bullets.GetPriTotalBullets();
            int CashNeeded = 20 * BulletsToBuy;

            // if hvae enough money to fill up to max total bullets
            if (weapon.GetCash() >= CashNeeded)
            {
                weapon.AddCash(-CashNeeded);
                bullets.SetPriTotalBullets(bullets.GetPriMaxTotalBullets());
            }
            else
            {
                // Not enough money to buy all of the "needed to fill up to max total bullets"
                // So we buy until have no money
                int BulletsICanBuy = weapon.GetCash() / 20;

                weapon.AddCash(-(BulletsICanBuy * 20));
                bullets.SetPriTotalBullets(bullets.GetPriTotalBullets() + BulletsICanBuy);
            }
        }
    }

    public void BuySecAmmo()
    {
        PlayerWeapons weapon = playerWeapon.GetComponent<PlayerWeapons>();
        BulletInventory bullets = playerWeapon.GetComponent<BulletInventory>();

        if (weapon.GetSecWeapon() == "228 Compact")
        {
            if (bullets.GetSecTotalBullets() < bullets.GetSecMaxTotalBullets())
            {
                int BulletsToBuy = bullets.GetSecMaxTotalBullets() - bullets.GetSecTotalBullets();
                int CashNeeded = 7 * BulletsToBuy;

                // if hvae enough money to fill up to max total bullets
                if (weapon.GetCash() >= CashNeeded)
                {
                    weapon.AddCash(-CashNeeded);
                    bullets.SetSecTotalBullets(bullets.GetSecMaxTotalBullets());
                }
                else
                {
                    // Not enough money to buy all of the "needed to fill up to max total bullets"
                    // So we buy until have no money
                    int BulletsICanBuy = weapon.GetCash() / 7;

                    weapon.AddCash(-(BulletsICanBuy * 7));
                    bullets.SetSecTotalBullets(bullets.GetSecTotalBullets() + BulletsICanBuy);
                }
            }
        }
        else if(weapon.GetSecWeapon() == "Desert Eagle")
        {
            if (bullets.GetSecTotalBullets() < bullets.GetSecMaxTotalBullets())
            {
                int BulletsToBuy = bullets.GetSecMaxTotalBullets() - bullets.GetSecTotalBullets();
                int CashNeeded = 28 * BulletsToBuy;

                // if hvae enough money to fill up to max total bullets
                if (weapon.GetCash() >= CashNeeded)
                {
                    weapon.AddCash(-CashNeeded);
                    bullets.SetSecTotalBullets(bullets.GetSecMaxTotalBullets());
                }
                else
                {
                    // Not enough money to buy all of the "needed to fill up to max total bullets"
                    // So we buy until have no money
                    int BulletsICanBuy = weapon.GetCash() / 28;

                    weapon.AddCash(-(BulletsICanBuy * 28));
                    bullets.SetSecTotalBullets(bullets.GetSecTotalBullets() + BulletsICanBuy);
                }
            }
        }
    }
}
