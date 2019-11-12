using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private GameObject noteGenerator;
    private NoteGenerator ng;

    private Queue<ValueInfo> jukeBox;
    private ValueInfo v;

    private float delta;

    // Start is called before the first frame update
    void Start()
    {
        noteGenerator = GameObject.Find("NoteGenerator");
        ng = noteGenerator.GetComponent<NoteGenerator>();
        delta = 0f;

        jukeBox = CreateSchoolBell();
        jukeBox = CreateLittleStar();
        //CreateLittleStar();
        //CreateSchoolBell();
    }

    // Update is called once per frame
    void Update()
    {
        if (jukeBox.Count <= 0)
        {
            Debug.Log("Empty Queue!");
            return;
        }
        if (delta == 0)
            v = jukeBox.Dequeue();

        delta += Time.deltaTime;

        if (delta > v.delay)
        {
            Debug.Log("delta over...");
            delta = 0f;
            ng.CreateNote(v.key, v.scale);
        }

        
    }
    private Queue<ValueInfo> CreateLittleStar()
    {
        Queue<ValueInfo> queue = new Queue<ValueInfo>();
        float term = 0.3f;

        queue.Enqueue(new ValueInfo("q", "c", term));
        queue.Enqueue(new ValueInfo("q", "c", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("r", "a", term));
        queue.Enqueue(new ValueInfo("r", "a", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "f", term));
        queue.Enqueue(new ValueInfo("e", "f", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("q", "d", term));
        queue.Enqueue(new ValueInfo("q", "d", term));
        queue.Enqueue(new ValueInfo("q", "c", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "f", term));
        queue.Enqueue(new ValueInfo("e", "f", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("q", "d", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "f", term));
        queue.Enqueue(new ValueInfo("e", "f", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("q", "d", term));
        queue.Enqueue(new ValueInfo("q", "c", term));
        queue.Enqueue(new ValueInfo("q", "c", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("r", "a", term));
        queue.Enqueue(new ValueInfo("r", "a", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "f", term));
        queue.Enqueue(new ValueInfo("e", "f", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("q", "d", term));
        queue.Enqueue(new ValueInfo("q", "d", term));
        queue.Enqueue(new ValueInfo("q", "c", term));
        queue.Enqueue(new ValueInfo("z", "z", term));

        return queue;
    }

    private Queue<ValueInfo> CreateSchoolBell()
    {
        Queue<ValueInfo> queue = new Queue<ValueInfo>();
        float term = 0.5f;

        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("r", "a", term));
        queue.Enqueue(new ValueInfo("r", "a", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("q", "d", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("r", "a", term));
        queue.Enqueue(new ValueInfo("r", "a", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("e", "g", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("q", "d", term));
        queue.Enqueue(new ValueInfo("w", "e", term));
        queue.Enqueue(new ValueInfo("q", "c", term));
        queue.Enqueue(new ValueInfo("z", "z", term));

        return queue;
    }
}
