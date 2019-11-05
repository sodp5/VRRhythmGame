using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    private GameObject musicManager;
    private List<GameObject> noteList;

    private string pressedKey;

    // Start is called before the first frame update
    void Start()
    {
        musicManager = GameObject.Find("MusicManager");
    }

    // Update is called once per frame
    void Update()
    {
        pressedKey = Input.inputString;

        if (!IsExistNote()) 
        {
            Debug.Log("not exist note");
            return;
        }
        if (!IsFrontNote(pressedKey))
        {
            Debug.Log("is not Front Note");
            return;
        }

        ProcessKeyEvent();
    }

    public void AddNote(GameObject note)
    {
        if (noteList == null)
            noteList = new List<GameObject>();

        Debug.Log("hello im add note");
        noteList.Add(note);
    }

    private void ProcessKeyEvent()
    {
        musicManager.SendMessage("PlaySound", noteList[0].GetComponent<NoteModel>().scale);
        Destroy(noteList[0]);
        noteList.Remove(noteList[0]);
        /*
        switch (key)
        {
            case "q":
                musicManager.SendMessage("PlaySound", "c");
                break;
            case "w":
                musicManager.SendMessage("PlaySound", "cS");
                break;
            case "e":
                musicManager.SendMessage("PlaySound", "d");
                break;
            case "r":
                musicManager.SendMessage("PlaySound", "dS");
                break;
            case "t":
                musicManager.SendMessage("PlaySound", "e");
                break;
            case "y":
                musicManager.SendMessage("PlaySound", "f");
                break;
            case "a":
                musicManager.SendMessage("PlaySound", "fS");
                break;
            case "s":
                musicManager.SendMessage("PlaySound", "g");
                break;
            case "d":
                musicManager.SendMessage("PlaySound", "gS");
                break;
            case "f":
                musicManager.SendMessage("PlaySound", "a");
                break;
            case "g":
                musicManager.SendMessage("PlaySound", "aS");
                break;
            case "h":
                musicManager.SendMessage("PlaySound", "b");
                break;
        }
        */
    }

    private bool IsFrontNote(string inputKey)
    {
        return noteList[0].GetComponent<NoteModel>().key.Equals(inputKey);
    }

    private bool IsExistNote()
    {
        return noteList.Count > 0;
    }

}
