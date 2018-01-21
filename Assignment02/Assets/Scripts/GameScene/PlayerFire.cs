using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{

    [SerializeField]
    GameObject bulletObj;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    //create a bullet
        //    Fire();
        //}
    }

    public void SpawnBullet()
    {
        Instantiate(bulletObj, transform.position, transform.rotation);
    }

    private void Fire()
    {
        BulletInventory bullets = GetComponent<BulletInventory>();

        if (bullets.ShootBullet(1))
        {
            SpawnBullet();
        }
    }
}
