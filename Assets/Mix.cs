using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    Camera cam;
    Vector3 pos = new Vector3 (0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay (pos);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
    }
}


