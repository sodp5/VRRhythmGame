using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    private GameObject musicManager;
    private List<GameObject> noteList;

    private string pressedKey;

    private void Awake()
    {
        if (noteList == null)
            noteList = new List<GameObject>();
    }

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

        noteList.Add(note);
    }

    private void ProcessKeyEvent()
    {
        musicManager.SendMessage("PlaySound", noteList[0].GetComponent<NoteModel>().scale);

        RemoveNote();
    }

    public void RemoveNote()
    {
        Destroy(noteList[0]);
        noteList.Remove(noteList[0]);
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
