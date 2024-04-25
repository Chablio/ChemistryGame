using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Camera cam;
    Vector3 pos = new Vector3(0, 0, 0);
    public GameObject door;
    public GameObject UICanvas;

    string chemical1 = "";
    string chemical2 = "";

    public GameObject box1;
    public GameObject box2;

    private bool box1Clicked = false;
    private bool box2Clicked = false;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pos.x = Input.mousePosition.x;
            pos.y = Input.mousePosition.y;
            float maxDistance = 3;
            Ray ray = cam.ScreenPointToRay(pos);

            if (Physics.Raycast(ray, out RaycastHit hit, maxDistance))
            {
                Debug.Log(hit.collider.gameObject.name + " was hit");

                if (hit.collider.gameObject.CompareTag("Container"))
                {
                    Chemicalspotions mix = hit.collider.gameObject.GetComponent<Chemicalspotions>();
                    Debug.Log("It was a container with " + mix.chemical);

                    if (chemical1 == "")
                    {
                        chemical1 = mix.chemical;
                    }
                    else if (chemical2 == "")
                    {
                        chemical2 = mix.chemical;
                    }
                }
                else if (hit.collider.gameObject == box1)
                {
                    Debug.Log("Box 1 was hit!");
                    box1Clicked = true;
                }
                else if (hit.collider.gameObject == box2)
                {
                    Debug.Log("Box 2 was hit!");
                    box2Clicked = true;
                }

                if (box1Clicked && box2Clicked)
                {
                    Debug.Log("You won!");
                }
            }

            if ((chemical1 == "Blue" && chemical2 == "Green") || (chemical1 == "Green" && chemical2 == "Blue"))
            {
                Debug.Log("solved!");
                door.SetActive(false);
            }
            else if ((chemical1 != "" && chemical2 != "") && ((chemical1 != "Blue" && chemical2 != "Green") || (chemical1 != "Green" && chemical2 != "Blue")))
            {
                Debug.Log("wrong!");
                chemical1 = "";
                chemical2 = "";
            }
        }
    }
}



