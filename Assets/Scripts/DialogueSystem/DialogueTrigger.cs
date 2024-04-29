using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Message[] messages;
    public Actor[] actors;

    public void StartDialogue() {
        FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors); // Fix this please...
    }

}

[System.Serializable]
public class Message {
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actor {
    public string name;
}