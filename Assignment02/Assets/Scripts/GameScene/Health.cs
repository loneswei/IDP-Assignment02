using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField]
    float healthPoints = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
    public void AddHealth(float amount)
    {
        healthPoints += amount;

        // Die
        if (healthPoints <= 0)
            Destroy(gameObject);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
