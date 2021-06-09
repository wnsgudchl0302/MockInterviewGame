using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class LastExit : MonoBehaviour, IPointerDownHandler
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerDown(PointerEventData data)
    {
        if (RulletController.CircleCnt == 2)
        {
            GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().Circle02.SetActive(false);
            GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().lastBg.SetActive(false);
            GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().Text02.SetActive(false);
        }

    }
}
