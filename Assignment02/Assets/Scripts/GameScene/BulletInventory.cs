using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInventory : MonoBehaviour
{

    [SerializeField]
    int MagBullets = 30;

    [SerializeField]
    int TotalBullets = 270;
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
    // Update is called once per frame
    void Update()
    {

    }
}
