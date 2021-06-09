using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightUpButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        GameObject.Find("ButtonManager").GetComponent<ButtonManager>().luOn.SetActive(false);
        GameObject.Find("ButtonManager").GetComponent<ButtonManager>().ruOn.SetActive(true);
    }
}
