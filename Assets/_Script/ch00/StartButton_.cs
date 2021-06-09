using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartButton_ : MonoBehaviour, IPointerDownHandler
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log(transform.name);
        SceneManager.LoadScene("ch01");


    }
}
