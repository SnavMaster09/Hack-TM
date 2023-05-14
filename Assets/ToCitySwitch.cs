using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCitySwitch : MonoBehaviour
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
                SceneManager.LoadScene("City");
                Debug.Log(1);
                touching = false;
            }
    }
}
