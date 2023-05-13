using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Trigger : MonoBehaviour
{
    public Dialogue dialogue;

    public bool hasFollowUp = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (hasFollowUp == true)
            {
                FindAnyObjectByType<Dialogue_Manager>().StartFollowUpDialogue(dialogue);
            }
            else
            {
                FindAnyObjectByType<Dialogue_Manager>().StartDialogue(dialogue);
            }
        }
    }

    public void enableFollowUp()
    {
        hasFollowUp = true;
    }

    public bool canFollowUp()
    {
        if (hasFollowUp == true)
            return true;
        else
            return false;


    }
}
