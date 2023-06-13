using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rb;
    public float velocityX;

    [SerializeField]
    UnityEngine.Events.UnityEvent iniciarDiálogo;

    private void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() { }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * velocityX, rb.velocity.y);
        animador();
    }

    void animador()
    {
        if (rb.velocity.x < 0)
        {
            animator.SetBool("Run", true);
            spriteRenderer.flipX = true;
        }

        if (rb.velocity.x > 0)
        {
            animator.SetBool("Run", true);
            spriteRenderer.flipX = false;
        }

        if (rb.velocity.y > 0 || rb.velocity.y < 0)
        {
            animator.SetBool("Jump", true);
        }
        else
            animator.SetBool("Jump", false);

        if (rb.velocity.x == 0)
            animator.SetBool("Run", false);
    }
}
