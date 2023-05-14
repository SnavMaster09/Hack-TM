using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class city_ui_manager : MonoBehaviour
{


    public GameObject ui1;
    public GameObject ui2;
    public GameObject ui3;

    // Update is called once per frame
    void Update()
    {
        if(ProgressionScript.phase == 1)
        {
            ui1.SetActive(true);
            ui2.SetActive(false);
            ui3.SetActive(false);

        }
        else if (ProgressionScript.phase == 2)
        {
            ui1.SetActive(false);
            ui2.SetActive(true);
            ui3.SetActive(false);

        }
        else if (ProgressionScript.phase == 3)
        {
            ui1.SetActive(false);
            ui2.SetActive(false);
            ui3.SetActive(true);

        }
        

    }
}
