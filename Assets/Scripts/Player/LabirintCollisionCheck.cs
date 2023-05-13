using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirintCollisionCheck : MonoBehaviour
{
    [SerializeField] private bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            canMove = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canMove = true;
    }
}
