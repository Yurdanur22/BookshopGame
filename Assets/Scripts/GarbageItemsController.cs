using UnityEngine;

public class GarbageItemsController : MonoBehaviour
{
    public GameObject missionText;
    int garbageCount;
    void Start()
    {
        garbageCount = GameObject.FindGameObjectsWithTag("Garbage").Length;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;
                if(clickedObject.tag == "Garbage")
                {
                    clickedObject.SetActive(false);
                    garbageCount--;
                    Debug.Log(garbageCount);

                    if (garbageCount <= 0)
                    {
                        missionText.SetActive(false);
                    }
                }
                
            }
        }
    }

}

