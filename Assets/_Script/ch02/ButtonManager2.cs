using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager2 : MonoBehaviour
{
    public GameObject clOn;
    public GameObject crOn;
    public GameObject save;

    // Start is called before the first frame update
    void Start()
    {
        clOn = GameObject.Find("CareerLeftButton").transform.Find("CareerLeftButtonOn").gameObject;
        crOn = GameObject.Find("CareerRightButton").transform.Find("CareerRightButtonOn").gameObject;
       
        save = GameObject.Find("Save").transform.Find("Save01").gameObject;

        clOn.SetActive(false);
        crOn.SetActive(false);

        save.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
