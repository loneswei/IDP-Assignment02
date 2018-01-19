﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    float movementSpeed = 10.0f;

    [SerializeField]
    GameObject player;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 distvec = (player.transform.position - gameObject.transform.position);
        float dist = distvec.magnitude;
        
        if (dist <= 5.0f)
        {
            // chase
            transform.position += distvec * Time.deltaTime;
        }

	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Bullet"))
        {
            Health healthScript = GetComponent<Health>();
            healthScript.AddHealth(-1.0f);
            Destroy(other.gameObject);
        }
    }
}