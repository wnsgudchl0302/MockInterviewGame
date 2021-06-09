using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cheak02 : MonoBehaviour, IPointerDownHandler
{
   int cheak;
    // Start is called before the first frame update
    void Start()
    {
        cheak = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerDown(PointerEventData data)
    { 
        GameObject.Find("ButtonManager3").GetComponent<ButtonManager3>().cheak02.SetActive(true);
    }
}
