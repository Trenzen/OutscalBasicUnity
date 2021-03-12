using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
   void Awake()
    {
        Debug.Log("My first Awake Function");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My first Start Function");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("My first Update Function");
        if(Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("F was pressed or Left click on Mouse");
        }

        if(Input.GetKey(KeyCode.F))
        {
            Debug.Log("F is being pressed");
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F has been released");
        }
    }
    void LateUpdate()
    {
        Debug.Log("My first Late Update Function");
    }
}
