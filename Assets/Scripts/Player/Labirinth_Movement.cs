using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirinth_Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D right;

    public Collider2D walls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            rb.velocity = new Vector2(-1, 0);
        if (Input.GetKey(KeyCode.D))
            rb.velocity = new Vector2(1, 0);
        if (Input.GetKey(KeyCode.W))
            rb.velocity = new Vector2(0, 1);
        if (Input.GetKey(KeyCode.S))
            rb.velocity = new Vector2(0, -1);


    }
    
    


}
