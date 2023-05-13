using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody2D rb;

    float moveSpeed = 3f;

    public Dialogue_Trigger trig;

    Vector2 movement;

    //public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        trig = GameObject.FindGameObjectWithTag("Gamer").GetComponent<Dialogue_Trigger>();
    }

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
        if (Input.GetKey(KeyCode.I))
            trig.enableFollowUp();


    }

    private void FixedUpdate()
    {
        Vector2 direction = movement.normalized;
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

    }
}
