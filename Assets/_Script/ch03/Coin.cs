using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text ScriptTxt;
    public string money;
 
    // Start is called before the first frame update
    void Start()
    {
        money = "10000";
        ScriptTxt.text = money;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
