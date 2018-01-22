using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInventory : MonoBehaviour
{

    [SerializeField]
    int MagBullets = 30;

    [SerializeField]
    int TotalBullets = 270;

    int MaxMag = 30;
    // Use this for initialization
    void Start()
    {

    }

    public bool ShootBullet(int amount)
    {
        MagBullets -= amount;

        // out of bullets
        if (MagBullets < 0)
            return false;
        else
            return true;
    }

    public int GetCurrMag()
    {
        return MagBullets;
    }

    public int GetMaxMag()
    {
        return MaxMag;
    }


    public void SetCurrMag(int set)
    {
        MagBullets = set;
    }

    public int GetAmmoStore()
    {
        return TotalBullets;
    }

    public void AddAmmoStore(int amt)
    {
        TotalBullets += amt;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
