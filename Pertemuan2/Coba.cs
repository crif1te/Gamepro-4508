using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coba : MonoBehaviour
{
    public string myName;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("Hello World");
        Debug.Log ("I am alive and my name is " + myName);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log ("Aku diulang-ulang");
    }
}
