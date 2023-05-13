using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdSceneSwitcher : MonoBehaviour
{
    private bool touching = false;

    public Dialogue_Trigger trig;



    private void Start()
    {
        trig = GameObject.FindGameObjectWithTag("Gamer").GetComponent<Dialogue_Trigger>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Player")
            touching = true;
    }
        

    private void Update()
    {
        if (touching == true)
            if (Dialogue_Manager.activeDialogue == false && trig.hasFollowUp == true && Player_Movement.ok == true)
            {
                SceneManager.LoadScene("FlappyBird");
                Debug.Log(1);
                touching = false;
            }
            
    }

}
