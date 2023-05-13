using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCafe : MonoBehaviour
{
    public Vector3 exitPos;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player_Movement.playerLoc = exitPos;
            SceneManager.LoadScene("City");
        }
    }
}
