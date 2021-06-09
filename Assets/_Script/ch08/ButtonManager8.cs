using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager8 : MonoBehaviour
{
    

    public GameObject btn01;
    public GameObject btn02;
    public GameObject character;

    public GameObject pBtn01;
    public GameObject pBtn02;
    public GameObject pBtn03;

    public GameObject pPopup;

    public GameObject qBtn01;
    public GameObject qBtn02;
    public GameObject qBtn03;
    public GameObject qBtn04;
    public GameObject qBtn05;
    public GameObject qBtn06;
    public GameObject qBtn07;

    public GameObject qPopup;

    public GameObject lastBg;

    public GameObject Circle01;
    public GameObject Circle02;
    public GameObject Text01;
    public GameObject Text02;







    // Start is called before the first frame update
    void Start()
    {
        

        btn01 = GameObject.Find("Btn01").transform.Find("Btn01_1").gameObject;
        btn02 = GameObject.Find("Btn02").transform.Find("Btn02_1").gameObject;
        character = GameObject.Find("Char").transform.Find("Charactor").gameObject;

        pBtn01 = GameObject.Find("pBtn01").transform.Find("pBtn01_1").gameObject;
        pBtn02 = GameObject.Find("pBtn02").transform.Find("pBtn02_1").gameObject;
        pBtn03 = GameObject.Find("pBtn03").transform.Find("pBtn03_1").gameObject;

        pPopup = GameObject.Find("pPopup").transform.Find("pPanel").gameObject;

        qBtn01 = GameObject.Find("qBtn01").transform.Find("qBtn01_1").gameObject;
        qBtn02 = GameObject.Find("qBtn02").transform.Find("qBtn02_1").gameObject;
        qBtn03 = GameObject.Find("qBtn03").transform.Find("qBtn03_1").gameObject;
        qBtn04 = GameObject.Find("qBtn04").transform.Find("qBtn04_1").gameObject;
        qBtn05 = GameObject.Find("qBtn05").transform.Find("qBtn05_1").gameObject;
        qBtn06 = GameObject.Find("qBtn06").transform.Find("qBtn06_1").gameObject;
        

        qPopup = GameObject.Find("qPopup").transform.Find("qPanel").gameObject;

        lastBg = GameObject.Find("LastCanvas").transform.Find("bg").gameObject;
        Circle01 = GameObject.Find("LastCanvas").transform.Find("Circle01").gameObject;
        Circle02 = GameObject.Find("LastCanvas").transform.Find("Circle02").gameObject;

        Text01 = GameObject.Find("LastCanvas").transform.Find("Text01").gameObject;
        Text02 = GameObject.Find("LastCanvas").transform.Find("Text02").gameObject;






        btn01.SetActive(true);
        btn02.SetActive(false);
        character.SetActive(true);

        pBtn01.SetActive(false);
        pBtn02.SetActive(false);
        pBtn03.SetActive(false);

        pPopup.SetActive(false);

        qBtn01.SetActive(false);
        qBtn02.SetActive(false);
        qBtn03.SetActive(false);
        qBtn04.SetActive(false);
        qBtn05.SetActive(false);
        qBtn06.SetActive(false);

        qPopup.SetActive(false);

        lastBg.SetActive(false);
        Circle01.SetActive(false);
        Circle02.SetActive(false);

        Text01.SetActive(false);
        Text02.SetActive(false);
        


    }

    // Update is called once per frame
    void Update()
    {

    }
}
