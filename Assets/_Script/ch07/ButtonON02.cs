using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class ButtonON02 : MonoBehaviour, IPointerDownHandler
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
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().btn01.SetActive(false);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().btn02.SetActive(true);
    }
}
