
using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour
{
   // public AudioClip switchSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
           // audio.PlayOneShot(switchSound);

            if (GetComponent<Light>().enabled)
            {
                GetComponent<Light>().enabled = false;
            }
            else
            {
                GetComponent<Light>().enabled = true;
            }
        }
    }
}