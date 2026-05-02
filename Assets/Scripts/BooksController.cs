using UnityEngine;

public class BooksController : MonoBehaviour
{
    public GameObject oldBookcase1;
    public GameObject oldBookcase2;
    public GameObject newBookcase1;
    public GameObject newBookcase2;
    public GameObject targetText1;
    public GameObject targetText2;
    public GameObject targetText3;
    private bool isClear = false;
    private bool isFinished = false;
    private bool isOkey = false;
    int itemCount;
    void Start()
    {
        itemCount = GameObject.FindGameObjectsWithTag("CollectItem").Length;
        targetText2.SetActive(false);
        targetText3.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            oldBookcase1.SetActive(false);
            oldBookcase2.SetActive(false);
            isClear = true;
        }
        if(isClear == true && isFinished == false)
        {
            targetText1.SetActive(false);
            targetText2.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;
                if(clickedObject.tag == "CollectItem")
                {
                    clickedObject.SetActive(false);
                    itemCount--;
                    Debug.Log(itemCount);
                    if(itemCount  <= 0)
                    {
                        isFinished = true;
                        targetText2.SetActive(false);
                        targetText3.SetActive(true);
                    }
                    
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            newBookcase1.SetActive(true);
            newBookcase2.SetActive(true);
            isOkey = true;
        }
        if(isOkey == true)
        {
            targetText3.SetActive(false);
        }
    }
}
