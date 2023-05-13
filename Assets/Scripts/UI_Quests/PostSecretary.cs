using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PostSecretary : MonoBehaviour
{
    public TMP_Text My_Text;


    private void OnCollisionExit2D(Collision2D collision)
    {
        My_Text.text = "Test";
    }
}
