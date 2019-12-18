using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtController : MonoBehaviour
{
    public Manager _manager;
    public NoteManager _noteManager;

    // Start is called before the first frame update
    void Start()
    {
        _manager.pressQ.AddListener(pressQ);
        _manager.pressW.AddListener(pressW);
        _manager.pressE.AddListener(pressE);
        _manager.pressR.AddListener(pressR);
    }

    void pressQ()
    {
        _noteManager.pressKey("q");
    }
    void pressW()
    {
        _noteManager.pressKey("w");
    }
    void pressE()
    {
        _noteManager.pressKey("e");
    }
    void pressR()
    {
        _noteManager.pressKey("r");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
