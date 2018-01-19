using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLook : MonoBehaviour {
    [SerializeField]
    float movementSpeed = 10;

    [SerializeField]
    float rotateSpeed = 1;

    [SerializeField]
    Image ImgFG;

    Vector3 yAxis;

    [SerializeField]
    Text printText;

    void Awake()
    {
        Debug.Log("Awake");
    }

    // Use this for initialization
    void Start () {
        Debug.Log("Start");
        yAxis = new Vector3(0, 1, 0);
    }
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * 180);

        // Vector3 newDir = Vector3.RotateTowards(transform.forward, new Vector3(ImgFG.rectTransform.localPosition.x, 0, ImgFG.rectTransform.localPosition.y), Time.deltaTime * rotateSpeed, 0.0f);
        // transform.rotation = Quaternion.LookRotation(newDir);

        if (ImgFG.rectTransform.localPosition.x > 0)
            transform.Rotate(new Vector3(0, (ImgFG.rectTransform.localPosition.x * 0.1f) * rotateSpeed, 0));
        if (ImgFG.rectTransform.localPosition.x < 0)
            transform.Rotate(new Vector3(0, (ImgFG.rectTransform.localPosition.x * 0.1f) * rotateSpeed, 0));

        //if (ImgFG.rectTransform.localPosition.y > 0 && transform.rotation.y * Mathf.Rad2Deg < 20)
        //{
        //    transform.Rotate(new Vector3(-(ImgFG.rectTransform.localPosition.y * 0.1f) * rotateSpeed, 0, 0));
        //    printText.text = "x: " + transform.rotation.x + "y: " + transform.rotation.y ;
        //}
        //if (ImgFG.rectTransform.localPosition.y < 0 && transform.rotation.y * Mathf.Rad2Deg > -20)
        //{
        //    transform.Rotate(new Vector3(-(ImgFG.rectTransform.localPosition.y * 0.1f) * rotateSpeed, 0, 0));
        //    printText.text = "x: " + transform.rotation.x + "y: " + transform.rotation.y;
        //}
    }
}
