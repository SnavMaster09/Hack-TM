using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeGiven : MonoBehaviour
{
    private bool touching = false;

    public Dialogue_Trigger trig;

    void Start()
    {
        trig = GameObject.FindGameObjectWithTag("Gamer").GetComponent<Dialogue_Trigger>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        touching = true;
    }

    private void Update()
    {
        if (touching == true)
            if (Dialogue_Manager.activeDialogue == false)
            {

                trig.enableFollowUp();
                touching = false;
            }
    }
}
