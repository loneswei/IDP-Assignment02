using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInventory : MonoBehaviour
{
    // Use this for initialization
    void Start(){}
    // Update is called once per frame
    void Update(){}

    // ================= Primary Weapon Start =================
    // Set Primary Weapons
    int PriCurrBullets;
    int PriTotalBullets;
    [SerializeField]
    int PriMaxBullets;
    [SerializeField]
    int PriMaxTotalBullets;

    public int GetPriCurrBullets() { return PriCurrBullets; }
    public void SetPriCurrBullets(int set) { PriCurrBullets = set; }
    public int GetPriTotalBullets() { return PriTotalBullets; }
    public void SetPriTotalBullets(int set) { PriTotalBullets = set; }
    public int GetPriMaxBullets() { return PriMaxBullets; }
    public void SetPriMaxBullets(int set) { PriMaxBullets = set; }
    public int GetPriMaxTotalBullets() { return PriMaxTotalBullets; }
    public void SetPriMaxTotalBullets(int set) { PriMaxTotalBullets = set; }

    public bool ShootPrimary(int amt)
    {
        if (PriCurrBullets - amt <= 0)
        {
            PriCurrBullets = 0;
            return false;
        }
        else
        {
            PriCurrBullets -= amt;
            return true;
        }
    }
    public void AddPriTotalBullets(int amt)
    {
        // Prevent it go to negative bullets
        if (PriTotalBullets + amt < 0)
            PriTotalBullets = 0;
        else
        {
            // Prevent it go above max bullets
            if (PriTotalBullets + amt <= PriMaxTotalBullets)
                PriTotalBullets += amt;
            else
                PriTotalBullets = PriMaxTotalBullets;
        }
    }
    // ================= Primary Weapon End =================

    // ================= Secondary Weapon Start =================
    // Set Secondary Weapons
    int SecCurrBullets = 13;
    int SecTotalBullets = 13;
    [SerializeField]
    int SecMaxBullets = 13;
    [SerializeField]
    int SecMaxTotalBullets = 52;

    public int GetSecCurrBullets() { return SecCurrBullets; }
    public void SetSecCurrBullets(int set) { SecCurrBullets = set; }
    public int GetSecTotalBullets() { return SecTotalBullets; }
    public void SetSecTotalBullets(int set) { SecTotalBullets = set; }
    public int GetSecMaxBullets() { return SecMaxBullets; }
    public void SetSecMaxBullets(int set) { SecMaxBullets = set; }
    public int GetSecMaxTotalBullets() { return SecMaxTotalBullets; }
    public void SetSecMaxTotalBullets(int set) { SecMaxTotalBullets = set; }

    public bool ShootSecondary(int amt)
    {
        if (SecCurrBullets - amt < 0)
        {
            SecCurrBullets = 0;
            return false;
        }
        else
        {
            SecCurrBullets -= amt;
            return true;
        }
    }
    public void AddSecTotalBullets(int amt)
    {
        // Prevent it go to negative bullets
        if (SecTotalBullets + amt <= 0)
            SecTotalBullets = 0;
        else
        {
            // Prevent it go above max bullets
            if (SecTotalBullets + amt <= SecMaxTotalBullets)
                SecTotalBullets += amt;
            else
                SecTotalBullets = SecMaxTotalBullets;
        }
    }
    // ================= Secondary Weapon End =================
}
