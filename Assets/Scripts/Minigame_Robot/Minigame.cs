using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Minigame : MonoBehaviour
{   char Lit;
    int cnt = 0;
    public TMP_Text MP_Text;
    void Start()
    {
        InvokeRepeating("Repuri", 1, 3);

    } void Repuri()
    {
        Lit = MP_Text.text[10];
        /*if (Input.GetKey(Keycode.Lit))
            cnt = cnt + 1;
          */  
    }
    void Update()
    {
        if (cnt == 5)
            SceneManager.LoadScene("Park");
    }

    

}
