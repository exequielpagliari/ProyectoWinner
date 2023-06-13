using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemyCangrejo : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocityX;
    private int direction;

    public float delay;

    private float time;

    private void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (time + delay < Time.time)
        {
            movimiento();
            time = Time.time;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(velocityX * direction, rb.velocity.y);
    }

    int movimiento()
    {
        direction = randomDirection();
        Debug.Log(direction);
        return direction;
    }

    private int randomDirection()
    {

        if (Random.Range(0, 3) == 0)
            direction = -1;
        if (Random.Range(0, 3) == 1)
            direction = 0;
        if (Random.Range(0, 3) == 2)
            direction = 1;
        return direction;
    }
}
