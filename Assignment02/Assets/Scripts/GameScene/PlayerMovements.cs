using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 10;

    [SerializeField]
    float rotateSpeed = 5;

    [SerializeField]
    Image ImgFG;

    Vector3 yAxis;

    [SerializeField]
    Text printText;

    void Awake()
    {
        //Debug.Log("Awake");
    }

    // Use this for initialization
    void Start()
    {
        //Debug.Log("Start");
        yAxis = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (ImgFG.rectTransform.localPosition.y > 10) //W
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime; //new Vector3(transform.position.x + 10 * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (ImgFG.rectTransform.localPosition.y < -10) //S
        {
            transform.position -= transform.forward * movementSpeed * Time.deltaTime; // new Vector3(transform.position.x - 10 * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (ImgFG.rectTransform.localPosition.x < 10) //A
        {
            transform.position -= transform.right * movementSpeed * Time.deltaTime; // new Vector3(transform.position.x, transform.position.y, transform.position.z + 10 * Time.deltaTime);
        }
        if (ImgFG.rectTransform.localPosition.x > -10) //D
        {
            transform.position += transform.right * movementSpeed * Time.deltaTime; // new Vector3(transform.position.x, transform.position.y, transform.position.z - 10 * Time.deltaTime);
        }


    }

    void LateUpdate()
    {
        //Debug.Log("LateUpdate");
    }
}
