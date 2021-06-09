using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject luOn;
    public GameObject ldOn;
    public GameObject ruOn;
    public GameObject rdOn;
    

    // Start is called before the first frame update
    void Start()
    {
        luOn = GameObject.Find("LeftUpButtonOff").transform.Find("LeftUpButtonOn").gameObject;
        ldOn = GameObject.Find("LeftDownButtonOff").transform.Find("LeftDownButtonOn").gameObject;
        ruOn = GameObject.Find("RightUpButtonOff").transform.Find("RightUpButtonOn").gameObject;
        rdOn = GameObject.Find("RightDownButtonOff").transform.Find("RightDownButtonOn").gameObject;
        

        
        luOn.SetActive(true);
        ldOn.SetActive(true);
        ruOn.SetActive(false);
        rdOn.SetActive(false);
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
