using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMove : MonoBehaviour {

    [SerializeField]
    float movementSpeed = 10.0f;

    //[SerializeField]
    //ParticleSystem explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Health healthScript = other.GetComponent<Health>();

        //if (healthScript != null)
        //{
            //ParticleSystem thisExplosion = Instantiate(explosion, transform.position, Quaternion.identity);
            //thisExplosion.Play();
            //healthScript.AddHealth(-10);

        //}

        //Destroy(gameObject);
    }
}