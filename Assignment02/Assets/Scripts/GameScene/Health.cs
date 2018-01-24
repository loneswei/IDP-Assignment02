using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    [SerializeField]
    float startHealth = 10.0f;
    float healthPoints;

    public Image healthBar;
    public GameObject PlayerHealthOverlay;
    float timerToRemoveOverlay;

    public GameObject WinScreen, LoseScreen;

	// Use this for initialization
	void Start () {
        healthPoints = startHealth;
	}
	
    public void AddHealth(float amount)
    {
        healthPoints += amount;

        if (gameObject.name.Contains("Enemy"))
            healthBar.fillAmount = healthPoints / startHealth;

        if (gameObject.name.Contains("Player"))
            PlayerHealthOverlay.SetActive(true);

        // Die
        if (healthPoints <= 0)
        {
            if(gameObject.name.Contains("Enemy"))
            {
                Destroy(gameObject);
                WinScreen.SetActive(true);
                Time.timeScale = 0.0f;
            }

            if(gameObject.name.Contains("Player"))
            {
                Destroy(gameObject);
                LoseScreen.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
    }
	// Update is called once per frame
	void Update ()
    {
        if (gameObject.name.Contains("Player"))
        {
            if (PlayerHealthOverlay.activeInHierarchy)
                timerToRemoveOverlay += Time.deltaTime;
            if (timerToRemoveOverlay >= 1.0f)
            {
                PlayerHealthOverlay.SetActive(false);
                timerToRemoveOverlay = 0.0f;
            }
        }
	}
}
