using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MailCheak : MonoBehaviour, IPointerDownHandler
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
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().MailCheak.SetActive(true);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().FemailCheak.SetActive(false);


    }
}
