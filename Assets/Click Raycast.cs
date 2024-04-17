using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    Camera cam;
    Vector3 pos = new Vector3(0, 0, 0);

    string currentHeldChemical = "";
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        // check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            pos.x = Input.mousePosition.x;
            pos.y = Input.mousePosition.y;
            float maxDistance = 3;
            Ray ray = cam.ScreenPointToRay(pos);
            //Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
            if(Physics.Raycast(ray, out RaycastHit hit, maxDistance))
            {
                Debug.Log(hit.collider.gameObject.name + " was hit");
                if(hit.collider.gameObject.CompareTag("Container"))
                {
                    Mixpotions mix = hit.collider.gameObject.GetComponent<Mixpotions>();
                    Debug.Log("It was a container with " + mix.chemical);
                }
            }
        }
       
    }


}


