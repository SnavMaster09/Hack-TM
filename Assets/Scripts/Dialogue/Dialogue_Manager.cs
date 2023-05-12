using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue_Manager : MonoBehaviour
{

    private  Queue<string> sentecens;

    public bool special = false;

    public static bool activeDialogue = false;


    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI nameText;

    public Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        sentecens = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        
        nameText.text = dialogue.name;

        animator.SetBool("isOpen", true);
        activeDialogue = true;

        sentecens.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentecens.Enqueue(sentence);
        }

        DisplayNextSentance();

    }

    public void DisplayNextSentance()
    {
        if(sentecens.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentecens.Dequeue();
        dialogueText.text = sentence;
        
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        activeDialogue = false;
    }

    
}
