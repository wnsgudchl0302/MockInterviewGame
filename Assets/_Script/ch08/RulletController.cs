using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulletController : MonoBehaviour
{
    public static int CircleCnt;
    float rotSpeed = 0; 

    void Start()
    {

        
    }

    void Update()
    {
        if (CircleCnt == 1)
        {
            this.rotSpeed = -2;
            transform.Rotate(0, 0, this.rotSpeed);
            StartCoroutine("Circle");
             
            
        }
       


    }

    IEnumerator Circle()
    {
        
        //Debug.Log("실행");
        yield return new WaitForSeconds(5f);
        // Debug.Log("정지");
        CircleCnt = 2;
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().Circle01.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().Text01.SetActive(false);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().Circle02.SetActive(true);
        GameObject.Find("ButtonManager8").GetComponent<ButtonManager8>().Text02.SetActive(true);

    }
}