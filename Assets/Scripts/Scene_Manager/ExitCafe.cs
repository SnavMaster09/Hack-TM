using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCafe : MonoBehaviour
{
    public Vector3 exitPos;

    public bool cafe;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(cafe == true)
            Player_Movement.playerLoc = new Vector3(2,-17.5f,0);
            else
            Player_Movement.playerLoc = new Vector3(17, 2, 0);
            SceneManager.LoadScene("City");
        }
    }
}
