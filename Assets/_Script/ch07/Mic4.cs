using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mic4 : MonoBehaviour
{
    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    public void PlaySnd()
    {
        aud.Play();

    }
    public void StopPlaySnd()
    {
        aud.Stop();

    }
    public void RecStopSnd()
    {
        Microphone.End(Microphone.devices[0]);
    }
    public void RecSnd()
    {
        aud.clip = Microphone.Start(Microphone.devices[0].ToString(), false, 30, 44100);
    }
}
