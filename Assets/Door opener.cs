using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropener : MonoBehaviour
{
    public GameObject door;

    public string Blue;
    public string Black;
    public string Green;
    public string Gray;
    // Start is called before the first frame update
    void Start()
    {
    } 

        // Tjek if chemicals match
    public void CheckChemicals(string Blue, string Black, string Green, string Gray)
    {
        if (this.Blue == Blue && this.Black == Black && this.Green == Green && this.Gray == Gray)
        {
            // open door
            door.SetActive(false); //
            Debug.Log("Door Opened");
        }
        else
        {
            Debug.Log("Chemicals do not match. Door remains closed");
        }
    }
 
}