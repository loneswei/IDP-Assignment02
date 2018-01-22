using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour {

    string primaryWeapon = "Def";
    string secondaryWeapon = "Default";
    string currweapon;
    string currWepType;

    // Use this for initialization
    void Start () {
        currweapon = secondaryWeapon;
        currWepType = "Secondary";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public string GetCurrWeapon()
    {
        return currweapon;
    }

    public string GetCurrWeaponType()
    {
        return currWepType;
    }

    public void Switch()
    {
        if (currweapon == secondaryWeapon)
        {
            if (primaryWeapon != "None")
            {
                currweapon = primaryWeapon;
                currWepType = "Primary";
            }
        }

        else if (currweapon == primaryWeapon)
        {
            if (secondaryWeapon != "None")
            {
                currweapon = secondaryWeapon;
                currWepType = "Secondary";
            }
        }
    }
}
