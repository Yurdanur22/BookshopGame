using DialogueEditor;
using Unity.VisualScripting;
using UnityEngine;

public class TalkNPC : MonoBehaviour
{
    public NPCConversation conversation;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ConversationManager.Instance.StartConversation(conversation);
        }
    }
    
}
