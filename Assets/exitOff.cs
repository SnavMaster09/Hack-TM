using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitOff : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ProgressionScript.talkedEnt == true)
            SceneManager.LoadScene("Park");
    }
}
