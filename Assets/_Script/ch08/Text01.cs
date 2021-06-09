using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text01 : MonoBehaviour
{
    public Text text01;

    // Start is called before the first frame update
    private void Awake()
    {
        text01.text = "#" + InputField01.fieldText1 + "  #" + InputField01.fieldText2 + "  #" + 
            InputField01.fieldText3 + "  #" + InputField01.fieldText4;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
