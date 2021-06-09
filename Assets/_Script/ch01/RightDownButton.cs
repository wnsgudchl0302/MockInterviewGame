using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDownButton : MonoBehaviour
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
        GameObject.Find("ButtonManager").GetComponent<ButtonManager>().ldOn.SetActive(false);
        GameObject.Find("ButtonManager").GetComponent<ButtonManager>().rdOn.SetActive(true);
    }
}
