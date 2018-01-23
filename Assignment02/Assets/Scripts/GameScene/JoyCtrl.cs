using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyCtrl : MonoBehaviour
{

    public Text printOut;
    private Image ImgFG;
    private Image ImgBG;

    Vector3 InitialPos;

    // Use this for initialization
    void Start()
    {
        ImgBG = GetComponent<Image>();
        ImgFG = transform.GetChild(0).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (Application.platform == RuntimePlatform.Android)
                Application.Quit();
        }
    }

    public void InitialPosition()
    {
#if UNITY_EDITOR
        InitialPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
#elif UNITY_ANDROID || UNITY_IOS
        Touch myTouch = Input.GetTouch(0);
        InitialPos = new Vector3(myTouch.position.x, myTouch.position.y, 1);
#else
        InitialPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
#endif
    }

    public void Dragging()
    {
        if (Time.timeScale == 0.0f) // if  paused, return
            return;
        
#if UNITY_EDITOR
        Vector2 tempPos = new Vector2(Input.mousePosition.x - InitialPos.x, Input.mousePosition.y - InitialPos.y);
#elif UNITY_ANDROID || UNITY_IOS
        Touch myTouch = Input.GetTouch(0);
        Vector2 tempPos = new Vector2(myTouch.position.x - InitialPos.x, myTouch.position.y - InitialPos.y);
#else
       Vector2 tempPos = new Vector2(Input.mousePosition.x - InitialPos.x, Input.mousePosition.y - InitialPos.y);

#endif
            Vector2 clampPos = Vector2.ClampMagnitude(tempPos, 50);
            Vector3 newPos = new Vector3(clampPos.x, clampPos.y, 1);

            ImgFG.rectTransform.localPosition = newPos;
        
    }

    public void ReturnOrigin()
    {
        if (Time.timeScale == 0.0f) // if  paused, return
            return;
        
        ImgFG.rectTransform.localPosition = new Vector3(0, 0, 1);
    }
}
