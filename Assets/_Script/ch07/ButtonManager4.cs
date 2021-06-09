using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager4 : MonoBehaviour
{
    public GameObject startOn1;
    public GameObject startOn2;
    public GameObject startOn3;
    public GameObject q1On;
    public GameObject q2On;
    public GameObject q3On;
    public GameObject q4On;

    public GameObject nextQOn;
   
    public GameObject play1;
    public GameObject rec1;
    public GameObject stop1;
    public GameObject play2;
    public GameObject rec2;
    public GameObject stop2;
    public GameObject play3;
    public GameObject rec3;
    public GameObject stop3;
    public GameObject play4;
    public GameObject rec4;
    public GameObject stop4;

    public GameObject play1_1;
    public GameObject play2_1;
    public GameObject play3_1;
    public GameObject play4_1;

    public GameObject Save01;
    public GameObject SaveYes01;
    public GameObject SaveNo01;

    public GameObject exitOn;

    public GameObject btn01;
    public GameObject btn02;

    // Start is called before the first frame update

   
    void Start()
    {
        startOn1 = GameObject.Find("Note").transform.Find("Start").gameObject;
        startOn2 = GameObject.Find("Note").transform.Find("Title").gameObject;
        startOn3 = GameObject.Find("Note").transform.Find("Start (1)").gameObject;
        nextQOn = GameObject.Find("Table").transform.Find("NextQuestion").gameObject;
        
        q1On = GameObject.Find("Note2").transform.Find("question01").gameObject;
        q2On = GameObject.Find("Note2").transform.Find("question02").gameObject;
        q3On = GameObject.Find("Note2").transform.Find("question03").gameObject;
        q4On = GameObject.Find("Note2").transform.Find("question04").gameObject;

        exitOn = GameObject.Find("Popup2").transform.Find("Panel2").gameObject;

        play1 = GameObject.Find("RECS_1").transform.Find("PlayButton").gameObject;
        rec1 = GameObject.Find("RECS_1").transform.Find("RECButton").gameObject;
        stop1 = GameObject.Find("RECS_1").transform.Find("StopButton").gameObject;

        play2 = GameObject.Find("RECS_2").transform.Find("PlayButton").gameObject;
        rec2 = GameObject.Find("RECS_2").transform.Find("RECButton").gameObject;
        stop2 = GameObject.Find("RECS_2").transform.Find("StopButton").gameObject;

        play3 = GameObject.Find("RECS_3").transform.Find("PlayButton").gameObject;
        rec3 = GameObject.Find("RECS_3").transform.Find("RECButton").gameObject;
        stop3 = GameObject.Find("RECS_3").transform.Find("StopButton").gameObject;

        play4 = GameObject.Find("RECS_4").transform.Find("PlayButton").gameObject;
        rec4 = GameObject.Find("RECS_4").transform.Find("RECButton").gameObject;
        stop4 = GameObject.Find("RECS_4").transform.Find("StopButton").gameObject;

        play1_1 = GameObject.Find("RECS_1_1").transform.Find("Button").gameObject;
        play2_1 = GameObject.Find("RECS_2_1").transform.Find("Button").gameObject;
        play3_1 = GameObject.Find("RECS_3_1").transform.Find("Button").gameObject;
        play4_1 = GameObject.Find("RECS_4_1").transform.Find("Button").gameObject;

        Save01 = GameObject.Find("SavePopup01").transform.Find("Save01").gameObject;
        SaveYes01 = GameObject.Find("Save01").transform.Find("Yes").gameObject;
        SaveNo01 = GameObject.Find("Save01").transform.Find("No").gameObject;

        btn01 = GameObject.Find("Btn01").transform.Find("Btn01_1").gameObject;
        btn02 = GameObject.Find("Btn02").transform.Find("Btn02_1").gameObject;

        q1On.SetActive(false);
        q2On.SetActive(false);
        q3On.SetActive(false);
        q4On.SetActive(false);

        exitOn.SetActive(false);
        
        nextQOn.SetActive(false);

        play1.SetActive(false);
        rec1.SetActive(false);
        stop1.SetActive(false);

        play2.SetActive(false);
        rec2.SetActive(false);
        stop2.SetActive(false);

        play3.SetActive(false);
        rec3.SetActive(false);
        stop3.SetActive(false);

        play4.SetActive(false);
        rec4.SetActive(false);
        stop4.SetActive(false);

        play1_1.SetActive(false);
        play2_1.SetActive(false);
        play3_1.SetActive(false);
        play4_1.SetActive(false);


        Save01.SetActive(false);

        btn01.SetActive(false);
        btn02.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
