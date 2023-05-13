using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrenght;
    public logic logc;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = " Benus";
        logc = GameObject.FindGameObjectWithTag("logc").GetComponent<logic>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true )
        rb.velocity = Vector2.up * flapStrenght;
        if (transform.position.y < -8 || transform.position.y > 8)
            logc.gameover();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(1);
        logc.gameover();
    }
}
