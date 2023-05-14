using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkEnttt : MonoBehaviour
{
    private bool touching = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        touching = true;
    }

    private void Update()
    {
        if (touching == true)
            if (Dialogue_Manager.activeDialogue == false)
            {
                ProgressionScript.talkedEnt = true;
                Debug.Log(1);
                touching = false;

            }
    }
}
