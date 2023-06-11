using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogue : MonoBehaviour
{
    public DialogueManager dialogueManager;

    private void Awake() {
        dialogueManager = FindFirstObjectByType<DialogueManager>();
    }

    private void Update()
    {
        Debug.Log(dialogo);
        if (Input.GetButtonDown("Fire1"))
        {
            if (dialogueManager.dialogueOn())
            {
                dialogueManager.DisplayNextSentence();
                return;
            }

            if (!dialogueManager.dialogueOn())
                dialogo.TriggerDialogue();
            return;
        }
    }

    private DialogueTrigger dialogo;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<DialogueTrigger>())
        {
            dialogo = other.gameObject.GetComponent<DialogueTrigger>();
        }
    }

private void OnTriggerExit2D(Collider2D other) {
    dialogo = null;
}
}
