using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public Image image;
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    private Queue<string> sentences;
    private Queue<string> names;
    private Queue<Sprite> imagens;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
        imagens = new Queue<Sprite>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Empezar conversación con : " + dialogue.names);

        animator.SetBool("IsOpen", true);

        names.Clear();

        sentences.Clear();

        imagens.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        foreach (string name in dialogue.names)
        {
            names.Enqueue(name);
        }

        foreach (Sprite imagen in dialogue.imagens)
        {
            imagens.Enqueue(imagen);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        if (names.Count == 0)
        {
            EndDialogue();
            return;
        }

        if (imagens.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        string name = names.Dequeue();
        Sprite imagen = imagens.Dequeue();
        Debug.Log(sentence);
        Debug.Log(name);
        dialogueText.text = sentence;
        nameText.text = name;
        image.sprite = imagen;
    }

    void EndDialogue()
    {
        Debug.Log("Terminó la conversación");
        animator.SetBool("IsOpen", false);
    }

    public bool dialogueOn()
    {
        return animator.GetBool("IsOpen");
    }
}
