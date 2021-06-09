using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LeftLoadScene3 : MonoBehaviour, IPointerDownHandler
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
        SaveData.count = 1;
        Debug.Log("이전씬");
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
        SceneManager.LoadScene("ch06");

    }


}




