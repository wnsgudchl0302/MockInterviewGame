using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class ImageOn4 : MonoBehaviour, IPointerDownHandler
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
        GameObject.Find("ButtonManager3").GetComponent<ButtonManager3>().ImageOn1.SetActive(false);
        GameObject.Find("ButtonManager3").GetComponent<ButtonManager3>().ImageOn2.SetActive(false);
        GameObject.Find("ButtonManager3").GetComponent<ButtonManager3>().ImageOn3.SetActive(false);
        GameObject.Find("ButtonManager3").GetComponent<ButtonManager3>().ImageOn4.SetActive(true);
    }
}
