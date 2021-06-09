using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class ButtonOn01_1 : MonoBehaviour, IPointerDownHandler
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
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().btn01.SetActive(true);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().btn02.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().character.SetActive(true);
    }
}
