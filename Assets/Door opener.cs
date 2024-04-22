using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropener : MonoBehaviour
{
    public GameObject door;

    public string Blue;
    public string Red;
    public string Green;
    // Start is called before the first frame update
    void Start()
    {
    } 

        // Tjek if chemicals match
    public void CheckChemicals(string Blue, string Red, string Green)
    {
        if (this.Blue == Blue && this.Red == Red && this.Green == Green)
        {
            // open door
            door.SetActive(false); //
            Debug.Log("Door Opened");
        }
        else
        {
            Debug.Log("Chemicals do not match. Door remains closed")
        }
    }
 
}