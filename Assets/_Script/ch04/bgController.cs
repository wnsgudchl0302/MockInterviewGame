using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgController : MonoBehaviour
{
    public static int bgCnt;
   

    void Start()
    {


    }

    void Update()
    {
        if (bgCnt == 1)
        {
            
            StartCoroutine("bg");


        }



    }

    IEnumerator bg()
    {

        //Debug.Log("실행");
        yield return new WaitForSeconds(0.1f);
        // Debug.Log("정지");
        GameObject.Find("ButtonManager3").GetComponent<ButtonManager3>().bg2.SetActive(false);
        bgCnt = 2;
        
        

    }
}