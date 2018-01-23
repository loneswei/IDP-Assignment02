using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    [SerializeField]
    float startHealth = 10.0f;
    float healthPoints;

    public Image healthBar;
	// Use this for initialization
	void Start () {
        healthPoints = startHealth;
	}
	
    public void AddHealth(float amount)
    {
        healthPoints += amount;

        if (gameObject.name.Contains("Enemy"))
            healthBar.fillAmount = healthPoints / startHealth;

        // Die
        if (healthPoints <= 0)
            Destroy(gameObject);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
