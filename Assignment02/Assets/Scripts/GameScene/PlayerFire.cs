using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField]
    GameObject bulletObj;

    // Use this for initialization
    void Start(){}
    // Update is called once per frame
    void Update(){}

    public void SpawnBullet() { Instantiate(bulletObj, transform.position, transform.rotation); }
    public void Fire()
    {
        BulletInventory bullets = GetComponent<BulletInventory>();
        PlayerWeapons weapons = GetComponent<PlayerWeapons>();

        if (weapons.GetCurrWeaponType() == "Primary")
        {
            if (bullets.ShootPrimary(1))
            {
                SpawnBullet();
            }
        }
        if (weapons.GetCurrWeaponType() == "Secondary")
        {
            if (bullets.ShootSecondary(1))
            {
                SpawnBullet();
            }
        }

    }
}
