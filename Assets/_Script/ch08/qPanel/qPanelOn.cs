using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class qPanelOn : MonoBehaviour, IPointerDownHandler
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
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().qBtn01.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().qBtn02.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().qBtn03.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().qBtn04.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().qBtn05.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().qBtn06.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().qPopup.SetActive(true);

    }
}
