using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {

    [SerializeField]
    GameObject bulletObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    //create a bullet
        //    Fire();
        //}
    }

    public void Fire()
    {
        Instantiate(bulletObj, transform.position, transform.rotation);
    }
}
