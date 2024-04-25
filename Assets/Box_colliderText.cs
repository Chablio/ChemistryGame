using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_colliderText : MonoBehaviour
{
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            print("ENTER!");
        }
    }
}