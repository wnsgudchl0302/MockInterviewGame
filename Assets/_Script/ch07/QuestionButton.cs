using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuestionButton : MonoBehaviour, IPointerDownHandler
{
    public int cnt = 0;
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
        
        cnt++;
        if (cnt == 1)
        {
            
            Debug.Log("2번문제");
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q1On.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q2On.SetActive(true);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q3On.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q4On.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play1.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec1.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop1.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play2.SetActive(true);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec2.SetActive(true);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop2.SetActive(true);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play3.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec3.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop3.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play4.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec4.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop4.SetActive(false);

        }
        if (cnt == 2)
        {
            Debug.Log("3번문제");
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q1On.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q2On.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q3On.SetActive(true);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q4On.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play1.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec1.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop1.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play2.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec2.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop2.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play3.SetActive(true);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec3.SetActive(true);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop3.SetActive(true);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play4.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec4.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop4.SetActive(false);

        }
        if(cnt == 3)
        {
            Debug.Log("4번문제");
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q1On.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q2On.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q3On.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().q4On.SetActive(true);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play1.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec1.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop1.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play2.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec2.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop2.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play3.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec3.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop3.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play4.SetActive(true);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec4.SetActive(true);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop4.SetActive(true);

        }
        if (cnt == 4)
        {
            Debug.Log("끝");
            

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play1.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec1.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop1.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play2.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec2.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop2.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play3.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec3.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop3.SetActive(false);

            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play4.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().rec4.SetActive(false);
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().stop4.SetActive(false);
          
            GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().exitOn.SetActive(true);
            cnt--;
      
        }
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().Save01.SetActive(false);
    }
}
