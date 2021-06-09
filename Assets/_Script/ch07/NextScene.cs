using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour, IPointerDownHandler
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
        SaveData.count = 0;


        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play1_1.SetActive(true);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play2_1.SetActive(true);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play3_1.SetActive(true);
        GameObject.Find("ButtonManager4").GetComponent<ButtonManager4>().play4_1.SetActive(true);
        Debug.Log("마지막씬");
        SceneManager.LoadScene("ch08");

    }


}




