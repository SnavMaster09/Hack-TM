using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class RandomLetter : MonoBehaviour
    {
    int rNum ;
    public TMP_Text My_Text;

    void Start() {
        InvokeRepeating("Letter", 0, 3);
    }
    public void Letter()
        {
        rNum = Random.Range(1, 27);
        if (rNum == 1) My_Text.text = "Hold down A";
        if (rNum == 2) My_Text.text = "Hold down B";
        if (rNum == 3) My_Text.text = "Hold down C";
        if (rNum == 4) My_Text.text = "Hold down D";
        if (rNum == 5) My_Text.text = "Hold down E";
        if (rNum == 6) My_Text.text = "Hold down F";
        if (rNum == 7) My_Text.text = "Hold down G";
        if (rNum == 8) My_Text.text = "Hold down H";
        if (rNum == 9) My_Text.text = "Hold down I";
        if (rNum == 10) My_Text.text = "Hold down J";
        if (rNum == 11) My_Text.text = "Hold down K";
        if (rNum == 12) My_Text.text = "Hold down L";
        if (rNum == 13) My_Text.text = "Hold down M";
        if (rNum == 14) My_Text.text = "Hold down N";
        if (rNum == 15) My_Text.text = "Hold down O";
        if (rNum == 16) My_Text.text = "Hold down P";
        if (rNum == 17) My_Text.text = "Hold down Q";
        if (rNum == 18) My_Text.text = "Hold down R";
        if (rNum == 19) My_Text.text = "Hold down S";
        if (rNum == 20) My_Text.text = "Hold down T";
        if (rNum == 21) My_Text.text = "Hold down U";
        if (rNum == 22) My_Text.text = "Hold down V";
        if (rNum == 23) My_Text.text = "Hold down W";
        if (rNum == 24) My_Text.text = "Hold down X";
        if (rNum == 25) My_Text.text = "Hold down Y";
        if (rNum == 26) My_Text.text = "Hold down Z";
    }
    }

