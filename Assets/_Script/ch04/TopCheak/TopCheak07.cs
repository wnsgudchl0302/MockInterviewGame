using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TopCheak07 : MonoBehaviour, IPointerDownHandler
{
    int cnt = 0;
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
        if (cnt == 0)
        {
            cnt++;
            GameObject.Find("TopButton (6)").GetComponent<Image>().color = new Color(0.33f, 0.66f, 1, 1);
        }

        else if (cnt == 1)
        {
            cnt--;
            GameObject.Find("TopButton (6)").GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }

    }
}
