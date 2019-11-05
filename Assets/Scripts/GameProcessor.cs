using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProcessor : MonoBehaviour
{
    private GameObject noteGenerator;
    // Start is called before the first frame update
    void Start()
    {
        noteGenerator = GameObject.Find("NoteGenerator");

        var dgr = noteGenerator.GetComponent<NoteGenerator>();
        dgr.CreateNote("q", "c");
        Debug.Log("after create note");
        dgr.CreateNote("q", "cS");

        // noteGenerator.SendMessage("CreateNote", new string[] { "q", "c" });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
