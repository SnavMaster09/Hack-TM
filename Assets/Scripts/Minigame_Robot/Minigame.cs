using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Minigame : MonoBehaviour
{   char Lit;
    int cnt = 0;
    public TMP_Text MP_Text;
    private  bool Pressed;
    void Start()
    {
        InvokeRepeating("Repuri", 0.1f, 3);
    }
    void Repuri()
    {
        Lit = MP_Text.text[6];
        Pressed = false;
    } 
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.A)) && Lit == 'A' && Pressed == false)
        { 
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.B)) && Lit == 'B' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.C)) && Lit == 'C' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.D)) && Lit == 'D' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.E)) && Lit == 'E' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.F)) && Lit == 'F' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.G)) && Lit == 'G' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.H)) && Lit == 'H' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.I)) && Lit == 'I' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.J)) && Lit == 'J' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.K)) && Lit == 'K' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.L)) && Lit == 'L' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.M)) && Lit == 'M' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.N)) && Lit == 'N' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.O)) && Lit == 'O' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.P)) && Lit == 'P' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.Q)) && Lit == 'Q' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.R)) && Lit == 'R' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.S)) && Lit == 'S' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.T)) && Lit == 'T' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.U)) && Lit == 'U' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.V)) && Lit == 'V' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.W)) && Lit == 'W' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.X)) && Lit == 'X' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.Y)) && Lit == 'Y' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }
        if ((Input.GetKeyDown(KeyCode.Z)) && Lit == 'Z' && Pressed == false)
        {
            cnt = cnt + 1;
            Pressed = true;
            Debug.Log(1);
        }

        if (cnt == 5)
            SceneManager.LoadScene("Park");
    }

    

}
