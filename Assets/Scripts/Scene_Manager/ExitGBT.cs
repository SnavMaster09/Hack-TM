using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGBT : MonoBehaviour
{
    public void exitGB()
    {
        ProgressionScript.phase = 2;
        SceneManager.LoadScene("City");
    }
}
