using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrerRightButton : MonoBehaviour
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
        GameObject.Find("ButtonManager2").GetComponent<ButtonManager2>().crOn.SetActive(true);
        GameObject.Find("ButtonManager2").GetComponent<ButtonManager2>().clOn.SetActive(false);
    }
}
