using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDownButton : MonoBehaviour
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
        GameObject.Find("ButtonManager").GetComponent<ButtonManager>().ldOn.SetActive(true);
        GameObject.Find("ButtonManager").GetComponent<ButtonManager>().rdOn.SetActive(false);
    }
}
