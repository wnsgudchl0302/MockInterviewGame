using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Yes2 : MonoBehaviour, IPointerDownHandler
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
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().BuyClick2.SetActive(false);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().BuyClick300.SetActive(false);
        GameObject.Find("ButtonManager2_5").GetComponent<ButtonManager2_5>().Wear03.SetActive(true);

        int money = int.Parse(coin.money) - 450;
        coin.ScriptTxt.text = money.ToString();
    }
}