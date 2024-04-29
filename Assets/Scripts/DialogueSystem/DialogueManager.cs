using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public TextMeshProUGUI actorName;
    public TextMeshProUGUI messageText;
    public RectTransform backgroundBox;

    private Message[] currentMessages;
    private Actor[] currentActors;
    int activeMessage = 0;

    public static bool isActive = false;

    private void Start() {
        backgroundBox.gameObject.SetActive(false);
    }

    public void OpenDialogue(Message[] messages, Actor[] actors) {
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;

        isActive = true;
        backgroundBox.gameObject.SetActive(true);

        DisplayMessage();
    }

    void DisplayMessage() {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDispay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDispay.name;
    }

    public void NextMessage() {
        activeMessage++;

        if(activeMessage < currentMessages.Length) {
            DisplayMessage();
        } else {
            backgroundBox.gameObject.SetActive(false);
            isActive = false;
        }
    }

    private void Update() {
        if(isActive && Input.GetMouseButtonDown(0)) {
            NextMessage();
        }
    }

}
