using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight1 : MonoBehaviour

{

    public float battery = 20;

    void Update()
    {

        battery = battery - Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (GetComponent<Light>().enabled == false)
            {
                if (battery > 0)
                {
                    GetComponent<Light>().enabled = true;
                }
            }

            else

            {
                GetComponent<Light>().enabled = false;
            }
        }

        if (battery < 0)
        {
            battery = 0;
            GetComponent<Light>().enabled = false;
        }
    }
}
