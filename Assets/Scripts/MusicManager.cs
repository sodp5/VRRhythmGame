using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip c;
    public AudioClip cS;
    public AudioClip d;
    public AudioClip dS;
    public AudioClip e;
    public AudioClip f;
    public AudioClip fS;
    public AudioClip g;
    public AudioClip gS;
    public AudioClip a;
    public AudioClip aS;
    public AudioClip b;

    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(string scale)
    {
        if (audio.isPlaying)
            audio.Stop();

        switch(scale)
        {
            case "c":
                audio.PlayOneShot(c);
                break;
            case "cS":
                audio.PlayOneShot(cS);
                break;
            case "d":
                audio.PlayOneShot(d);
                break;
            case "dS":
                audio.PlayOneShot(dS);
                break;
            case "e":
                audio.PlayOneShot(e);
                break;
            case "f":
                audio.PlayOneShot(f);
                break;
            case "fS":
                audio.PlayOneShot(fS);
                break;
            case "g":
                audio.PlayOneShot(g);
                break;
            case "gS":
                audio.PlayOneShot(gS);
                break;
            case "a":
                audio.PlayOneShot(a);
                break;
            case "aS":
                audio.PlayOneShot(aS);
                break;
            case "b":
                audio.PlayOneShot(b);
                break;
        }
    }
}
