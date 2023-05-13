using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class RandomLetter : MonoBehaviour
    {
    int rNum ;
    public TMP_Text My_Text;

    void Start() {
        InvokeRepeating("Letter", 0, 1);
    }
    public void Letter()
        {
       
        rNum = Random.Range(1, 27);
        if (rNum == 1) My_Text.text = "Press A";
        if (rNum == 2) My_Text.text = "Press B";
        if (rNum == 3) My_Text.text = "Press C";
        if (rNum == 4) My_Text.text = "Press D";
        if (rNum == 5) My_Text.text = "Press E";
        if (rNum == 6) My_Text.text = "Press F";
        if (rNum == 7) My_Text.text = "Press G";
        if (rNum == 8) My_Text.text = "Press H";
        if (rNum == 9) My_Text.text = "Press I";
        if (rNum == 10) My_Text.text = "Press J";
        if (rNum == 11) My_Text.text = "Press K";
        if (rNum == 12) My_Text.text = "Press L";
        if (rNum == 13) My_Text.text = "Press M";
        if (rNum == 14) My_Text.text = "Press N";
        if (rNum == 15) My_Text.text = "Press O";
        if (rNum == 16) My_Text.text = "Press P";
        if (rNum == 17) My_Text.text = "Press Q";
        if (rNum == 18) My_Text.text = "Press R";
        if (rNum == 19) My_Text.text = "Press S";
        if (rNum == 20) My_Text.text = "Press T";
        if (rNum == 21) My_Text.text = "Press U";
        if (rNum == 22) My_Text.text = "Press V";
        if (rNum == 23) My_Text.text = "Press W";
        if (rNum == 24) My_Text.text = "Press X";
        if (rNum == 25) My_Text.text = "Press Y";
        if (rNum == 26) My_Text.text = "Press Z";
    }   
    }

