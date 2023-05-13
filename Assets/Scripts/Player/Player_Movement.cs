using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody2D rb;

    float moveSpeed = 3f;

    public static bool ok = false;
    public static Vector3 playerLoc;

    Vector2 movement;

    private void Start()
    {
        gameObject.transform.position = playerLoc;
    }

    //public Animator animator;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        /*
        if (rb.velocity.y > 0)
        {
            animator.SetBool("runUp", true);
            animator.SetBool("runDown", false);
            animator.SetBool("idle", false);

        }
        else if (rb.velocity.y < 0)
        {
            animator.SetBool("runDown", true);
            animator.SetBool("runUp", false);
            animator.SetBool("idle", false);
        }
        else
        {
            animator.SetBool("idle",true);
        }
        */
   


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gamer")
            ok = true;
        else
            ok = false;
        
    }

    private void FixedUpdate()
    {
        Vector2 direction = movement.normalized;
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

    }
}
