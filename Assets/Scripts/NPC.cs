using UnityEngine;
using DialogueEditor;
using Unity.VisualScripting;
public class NPC : MonoBehaviour
{
    public NPCConversation conversation;
    void Start()
    {
        ConversationManager.Instance.StartConversation(conversation);
    }

}
