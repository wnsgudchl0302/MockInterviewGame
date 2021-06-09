using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public static int count;
    void Awake()
    {

        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (count == 0)
        {
            DontDestroyOnLoad(gameObject);

        }
        if (count == 2)
        {
            GameObject.Destroy(gameObject);
        }

    }
}
