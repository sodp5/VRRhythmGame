using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteModel : MonoBehaviour
{
    public string key;
    public string scale;

    NoteModel(string key, string scale)
    {
        this.key = key;
        this.scale = scale;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitNote(string key, string scale)
    {
        this.key = key;
        this.scale = scale;
    }
}
