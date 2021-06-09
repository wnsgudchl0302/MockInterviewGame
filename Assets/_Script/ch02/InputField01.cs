using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField01 : MonoBehaviour
{
    public InputField inputField01;
    public InputField inputField02;
    public InputField inputField03;
    public InputField inputField04;
    public static string fieldText1;
    public static string fieldText2;
    public static string fieldText3;
    public static string fieldText4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fieldText1 = inputField01.text;
        fieldText2 = inputField02.text;
        fieldText3 = inputField03.text;
        fieldText4 = inputField04.text;
    }
}
