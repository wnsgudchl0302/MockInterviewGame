using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NextQuestion : MonoBehaviour, IPointerDownHandler
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
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().Save01.SetActive(true);

    }
}

