using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    float moveSpeed = 3f;

    public static bool ok = false;
    public static Vector3 playerLoc;

    Vector2 movement;

    private void Start()
    {
        
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
          string sceneName = currentScene.name;

            if (sceneName == "City")
            {
                gameObject.transform.position = playerLoc;
            }
            else
            {
            gameObject.transform.position = Vector3.zero;
            }
            
    }

    //public Animator animator;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        if (rb.velocity.y > 0)
        {
            animator.SetBool("runUp", true);
            animator.SetBool("runDown", false);
            animator.SetBool("runRight", false);
            animator.SetBool("runLeft", false);
            animator.SetBool("idle", false);

        }
        else if (rb.velocity.y < 0)
        {
            animator.SetBool("runDown", true);
            animator.SetBool("runUp", false);
            animator.SetBool("runRight", false);
            animator.SetBool("runLeft", false);
            animator.SetBool("idle", false);
        }
        else if(rb.velocity.x > 0)
        {
            animator.SetBool("runRight", true);
            animator.SetBool("runLeft", false);
            animator.SetBool("runDown", false);
            animator.SetBool("runUp", false);
            animator.SetBool("idle", false);
        }
        else if(rb.velocity.x < 0)
        {
            animator.SetBool("runRight", false);
            animator.SetBool("runLeft", true);
            animator.SetBool("runDown", false);
            animator.SetBool("runUp", false);
            animator.SetBool("idle", false);
        }
        else
        {
            animator.SetBool("idle",true);
        }
        
   


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
