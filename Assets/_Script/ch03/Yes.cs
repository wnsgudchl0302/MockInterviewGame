﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Yes : MonoBehaviour, IPointerDownHandler
{
    Coin coin;
    // Start is called before the first frame update
    void Start()
    {
        coin = GameObject.Find("Coin").GetComponent<Coin>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerDown(PointerEventData data)
    {
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().BuyClick.SetActive(false);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().BuyClick150.SetActive(false);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().Wear02.SetActive(true);
        int money = int.Parse(coin.money) - 150;
        coin.ScriptTxt.text = money.ToString();


    }
}