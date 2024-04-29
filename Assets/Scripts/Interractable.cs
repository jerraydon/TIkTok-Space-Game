using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interractable : MonoBehaviour {

    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    void Update() {
        if(isInRange) {
            if(Input.GetKeyDown(interactKey)) {
                interactAction?.Invoke();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            isInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            isInRange = false;
        }
    }

}
