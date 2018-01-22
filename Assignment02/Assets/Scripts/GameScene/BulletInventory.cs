using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInventory : MonoBehaviour
{
    //Set Primary Weapons
    [SerializeField]
    int PriMaxMag = 30;

    [SerializeField]
    int PriTotalBullets = 270;

    int PriMagBullets = 30;

    //Set Secondary Weapons
    [SerializeField]
    int SecMaxMag = 12;

    [SerializeField]
    int SecTotalBullets = 60;

    int SecMagBullets = 12;

    // Use this for initialization
    void Start()
    {

    }

    //Primary
    public bool ShootPrimary(int amount)
    {
        PriMagBullets -= amount;

        // out of bullets
        if (PriMagBullets < 0)
            return false;
        else
            return true;
    }

    public int GetPriCurrMag()
    {
        return PriMagBullets;
    }

    public int GetPriMaxMag()
    {
        return PriMaxMag;
    }


    public void SetPriCurrMag(int set)
    {
        PriMagBullets = set;
    }

    public int GetPriAmmoStore()
    {
        return PriTotalBullets;
    }

    public void AddPriAmmoStore(int amt)
    {
        PriTotalBullets += amt;
    }

    //Secondary
    public bool ShootSecondary(int amount)
    {
        SecMagBullets -= amount;

        // out of bullets
        if (SecMagBullets < 0)
            return false;
        else
            return true;
    }

    public int GetSecCurrMag()
    {
        return SecMagBullets;
    }

    public int GetSecMaxMag()
    {
        return SecMaxMag;
    }


    public void SetSecCurrMag(int set)
    {
        SecMagBullets = set;
    }

    public int GetSecAmmoStore()
    {
        return SecTotalBullets;
    }

    public void AddSecAmmoStore(int amt)
    {
        SecTotalBullets += amt;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
