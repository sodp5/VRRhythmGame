using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteModel : MonoBehaviour
{
    public string key;
    public string scale;

    Vector3 target = new Vector3(0, -15f, -20f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);
        if (transform.position == target)
        {
            Debug.Log("arrive~~");
            Destroy(gameObject);
        }
    }

    public void InitNote(string key, string scale)
    {
        this.key = key;
        this.scale = scale;
    }
}
