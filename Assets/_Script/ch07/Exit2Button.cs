using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Exit2Button : MonoBehaviour, IPointerDownHandler
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
        Debug.Log("종료");
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().exitOn.SetActive(false);
    }
}
