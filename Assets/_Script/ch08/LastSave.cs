using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class LastSave : MonoBehaviour, IPointerDownHandler
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
       
        Debug.Log("마지막");
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().lastBg.SetActive(true);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().Circle01.SetActive(true);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().Text01.SetActive(true);
        RulletController.CircleCnt = 1;


    }
}
