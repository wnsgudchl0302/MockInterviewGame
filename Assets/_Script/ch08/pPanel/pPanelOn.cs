using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class pPanelOn : MonoBehaviour, IPointerDownHandler
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
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().pBtn01.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().pBtn02.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().pBtn03.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().pPopup.SetActive(true);

    }
}
