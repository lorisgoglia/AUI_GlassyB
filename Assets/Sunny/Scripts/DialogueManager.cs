using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters; LUI è AMICO CHE FA PROBLEMI CON LA BUILD

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    private Queue<string> sentences;

    // [SerializeField] public Button btn;
    // Image img;
    public Animator animator;

    void Start()
    {
        sentences = new Queue<string>();
        //img = btn.GetComponent<Image>();
        //img.color = new Color(255, 255, 255, 255);

    }

    public void StartDialogue(Dialogue dialogue){

        Debug.Log("Starting conversation with " + dialogue.name);

        //nameText.text = dialogue.name;

        sentences.Clear();

        //animator.SetBool("IsIn", true);


        //FindObjectOfType<DialogueCanvas>().FadeCanvas(false);

      
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        /*
        foreach (var item in sentences)
        {
            Debug.Log(item);
        }

        */

        //StartCoroutine(TimeWaitingNextSentence());

        DisplayNextSentence();

    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        dialogueText.text = sentence;

    }


    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }
}
