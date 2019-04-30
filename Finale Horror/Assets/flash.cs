using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (GetComponent<Light>().enabled == true)
            {
                GetComponent<Light>().enabled = false;
                Debug.Log("light is now false");
            }
           else if (GetComponent<Light>().enabled == false)
            {
                GetComponent<Light>().enabled = true;
                Debug.Log("light is now true");
            }
        }
    }
}
