using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopScene : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
