using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Wearing03 : MonoBehaviour, IPointerDownHandler
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
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().SucWear01.SetActive(false);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().SucWear02.SetActive(false);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().SucWear03.SetActive(true);

        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().Wear01.SetActive(true);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().Wear02.SetActive(true);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().Wear03.SetActive(false);

        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().Hair01.SetActive(false);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().Hair02.SetActive(false);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().Hair03.SetActive(true);



    }
}
