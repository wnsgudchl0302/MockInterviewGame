using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager3 : MonoBehaviour
{
    public GameObject jobOn;
    public GameObject exitOn;

    public GameObject cheak01;
    public GameObject cheak02;
    public GameObject cheak03;
    public GameObject cheak04;
    public GameObject cheak05;
    public GameObject cheak06;
    public GameObject cheak07;

    public GameObject TopCheak01;

    public GameObject ImageOn1;
    public GameObject ImageOn2;
    public GameObject ImageOn3;
    public GameObject ImageOn4;

    public GameObject bg2;

   
    // Start is called before the first frame update
    void Start()
    {
        jobOn = GameObject.Find("Popup").transform.Find("Panel").gameObject;
        cheak01 = GameObject.Find("Circle01").transform.Find("Button (1)").gameObject;
        cheak02 = GameObject.Find("Circle02").transform.Find("Button (1)").gameObject;
        cheak03 = GameObject.Find("Circle03").transform.Find("Button (1)").gameObject;
        cheak04 = GameObject.Find("Circle04").transform.Find("Button (1)").gameObject;
        cheak05 = GameObject.Find("Circle05").transform.Find("Button (1)").gameObject;
        cheak06 = GameObject.Find("Circle06").transform.Find("Button (1)").gameObject;
        cheak07 = GameObject.Find("Circle07").transform.Find("Button (1)").gameObject;

        TopCheak01 = GameObject.Find("ScrollBackground").transform.Find("TopButton").gameObject;

        ImageOn1 = GameObject.Find("Image1").transform.Find("ImageOn1").gameObject;
        ImageOn2 = GameObject.Find("Image2").transform.Find("ImageOn2").gameObject;
        ImageOn3 = GameObject.Find("Image3").transform.Find("ImageOn3").gameObject;
        ImageOn4 = GameObject.Find("Image4").transform.Find("ImageOn4").gameObject;

        bg2 = GameObject.Find("Canvas11").transform.Find("bg2").gameObject;



        jobOn.SetActive(false);
        cheak01.SetActive(false);
        cheak02.SetActive(false);
        cheak03.SetActive(false);
        cheak04.SetActive(false);
        cheak05.SetActive(false);
        cheak06.SetActive(false);
        cheak07.SetActive(false);

        ImageOn1.SetActive(false);
        ImageOn2.SetActive(false);
        ImageOn3.SetActive(false);
        ImageOn4.SetActive(false);
        bg2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
