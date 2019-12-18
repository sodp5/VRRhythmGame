using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject button;
    public GameObject scene;

    public void change()
    {
        gameObject.SetActive(false);
        scene.SetActive(true);
    }
}
