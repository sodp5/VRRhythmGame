using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueInfo
{
    public string key;
    public string scale;
    public float delay;

    public ValueInfo(string key, string scale, float delay)
    {
        this.key = key;
        this.scale = scale;
        this.delay = delay;
    }
}
