using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownExample : MonoBehaviour
{
    [Header("Dropdown")]
    public Dropdown dropdown;

    void Start()
    {
        SetDropdownOptionsExample();
    }

    void Update()
    {

    }

    private void SetDropdownOptionsExample()// Dropdown 목록 생성
    {
        dropdown.options.Clear();
        for (int i = 1; i < 11; i++)//1부터 10까지
        {
            Dropdown.OptionData option = new Dropdown.OptionData();
            option.text = i.ToString() + "갯수";
            dropdown.options.Add(option);
        }
    }

    public void SelectButton()// SelectButton을 누름으로써 값 테스트.
    {
        Debug.Log("Dropdown Value: " + dropdown.value + ", List Selected: " + (dropdown.value + 1));
    }
}


