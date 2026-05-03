using DialogueEditor;
using UnityEngine;
using UnityEngine.UI;

public class Customers : MonoBehaviour
{
    public GameObject talkText;
    public GameObject customersPopup;
    public GameObject customerText;
    public Button customer1;
    public Button customer2;
    public Button customer3;
    public Button customer4;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public NPCConversation conversation1;
    public NPCConversation conversation2;
    public NPCConversation conversation3;
    public NPCConversation conversation4;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            talkText.SetActive(false);
            customerText.SetActive(true);
            customersPopup.SetActive(true);
        }
    }
    public void SelectCharacter1()
    {
        c1.SetActive(true);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        ConversationManager.Instance.StartConversation(conversation1);
    }
    public void SelectCharacter2()
    {
        c1.SetActive(false);
        c2.SetActive(true);
        c3.SetActive(false);
        c4.SetActive(false);
        ConversationManager.Instance.StartConversation(conversation2);
    }
    public void SelectCharacter3()
    {
        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(true);
        c4.SetActive(false);
        ConversationManager.Instance.StartConversation(conversation3);
    }
    public void SelectCharacter4()
    {
        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(true);
        ConversationManager.Instance.StartConversation(conversation4);
    }

}
