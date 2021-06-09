using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager2_5 : MonoBehaviour
{
    public GameObject BuyClick;
    public GameObject BuyClick2;
    public GameObject BuyClick150;
    public GameObject BuyClick300;
    public GameObject MailCheak;
    public GameObject FemailCheak;
    public GameObject Wear01;
    public GameObject Wear02;
    public GameObject Wear03;
    public GameObject SucWear01;
    public GameObject SucWear02;
    public GameObject SucWear03;
    public GameObject Hair01;
    public GameObject Hair02;
    public GameObject Hair03;
    public GameObject Success;

    // Start is called before the first frame update
    void Start()
    {
        BuyClick = GameObject.Find("BuyPopup").transform.Find("Buy").gameObject;
        BuyClick150 = GameObject.Find("RightButtonOff02").transform.Find("RightButtonOn02").gameObject;

        BuyClick2 = GameObject.Find("BuyPopup2").transform.Find("Buy").gameObject;
        BuyClick300 = GameObject.Find("RightButtonOff03").transform.Find("RightButtonOn03").gameObject;

        MailCheak = GameObject.Find("Image1").transform.Find("Cheak1").gameObject;
        FemailCheak = GameObject.Find("Image2").transform.Find("Cheak2").gameObject;

        Wear01 = GameObject.Find("Character01").transform.Find("LeftButtonOff01").gameObject;
        Wear02 = GameObject.Find("Character02").transform.Find("LeftButtonOff02").gameObject;
        Wear03 = GameObject.Find("Character03").transform.Find("LeftButtonOff03").gameObject;
        
        SucWear01 = GameObject.Find("Character01").transform.Find("LeftButtonOn01").gameObject;
        SucWear02 = GameObject.Find("Character02").transform.Find("LeftButtonOn02").gameObject;
        SucWear03 = GameObject.Find("Character03").transform.Find("LeftButtonOn03").gameObject;

        Hair01 = GameObject.Find("Charactor").transform.Find("Hair01").gameObject;
        Hair02 = GameObject.Find("Charactor").transform.Find("Hair02").gameObject;
        Hair03 = GameObject.Find("Charactor").transform.Find("Hair03").gameObject;

        Success = GameObject.Find("Success").transform.Find("Success01").gameObject;




        BuyClick.SetActive(false);
        BuyClick2.SetActive(false);

        MailCheak.SetActive(false);
        FemailCheak.SetActive(false);

        Wear01.SetActive(false);
        Wear02.SetActive(false);
        Wear03.SetActive(false);

        SucWear01.SetActive(true);
        SucWear02.SetActive(false);
        SucWear03.SetActive(false);

        Hair01.SetActive(true);
        Hair03.SetActive(false);
        Hair02.SetActive(false);

        Success.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
