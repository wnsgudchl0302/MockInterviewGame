using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MicButton : MonoBehaviour, IPointerDownHandler
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
        Debug.Log(transform.name);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().startOn1.SetActive(false);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().startOn2.SetActive(false);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().startOn3.SetActive(false);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q1On.SetActive(true);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().nextQOn.SetActive(true);

        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play1.SetActive(true);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec1.SetActive(true);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop1.SetActive(true);

        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play2.SetActive(false);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec2.SetActive(false);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop2.SetActive(false);

        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play3.SetActive(false);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec3.SetActive(false);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop3.SetActive(false);

        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play4.SetActive(false);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec4.SetActive(false);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop4.SetActive(false);
    }
}
