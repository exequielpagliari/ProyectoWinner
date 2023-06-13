using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anima : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() { }

    private void FixedUpdate()
    {
        if (rb.velocity.x != 0)
            animator.SetBool("Caminar", true);
        if (rb.velocity.x == 0)
            animator.SetBool("Caminar", false);

        if (rb.velocity.x < 0)
            this.GetComponent<SpriteRenderer>().flipX = false;
        if (rb.velocity.x > 0)
            this.GetComponent<SpriteRenderer>().flipX = true;
    }
}
