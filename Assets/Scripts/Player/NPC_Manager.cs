using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPC_Manager : MonoBehaviour
{
    public Dialogue dialogue;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            FindAnyObjectByType<Dialogue_Manager>().StartDialogue(dialogue);
    }
}
