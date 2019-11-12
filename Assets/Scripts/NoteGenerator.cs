using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGenerator : MonoBehaviour
{
    public GameObject notePrefab;

    private GameObject noteManager;

    private float delta;
    private float createTerm;


    // Start is called before the first frame update
    void Start()
    {
        delta = 0f;
        createTerm = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        delta += Time.deltaTime;
        if (delta > createTerm)
        {
            delta = 0f;
            GameObject go = Instantiate(notePrefab) as GameObject;
            go.transform.position = new Vector3(10, 10, 0);
        }
        */
    }

    public void CreateNote(string key, string scale)
    {
        if (noteManager == null)
            noteManager = GameObject.Find("NoteManager");

        var modelScript = notePrefab.GetComponent<NoteModel>();
        modelScript.InitNote(key, scale);

        GameObject go = Instantiate(notePrefab);

        var managerScript = noteManager.GetComponent<NoteManager>();
        managerScript.AddNote(go);

        go.transform.position = new Vector3(GetPositionByKey(key), -10, 18);
        go.GetComponent<MeshRenderer>().material.color = GetColorByKey(key);
    }

    private Color GetColorByKey(string key)
    {
        Color color;

        switch (key)
        {
            case "q":
                color = Color.blue;
                break;
            case "w":
                color = Color.green;
                break;
            case "e":
                color = Color.yellow;
                break;
            case "r":
                color = Color.red;
                break;
            default:
                color = Color.white;
                break;
        }

        return color;
    }

    private int GetPositionByKey(string key)
    {
        int position = 0;

        switch(key)
        {
            case "q":
                position = -9;
                break;
            case "w":
                position = 0;
                break;
            case "e":
                position = 9;
                break;
            case "r":
                position = 18;
                break;
        }

        return position;
    }
}
