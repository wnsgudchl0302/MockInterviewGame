using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cheak07 : MonoBehaviour, IPointerDownHandler
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

        GameObject.Find("ButtonManager3").GetComponent<ButtonManager3>().cheak07.SetActive(true);
    }
}
