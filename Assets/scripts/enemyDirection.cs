using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDirection : MonoBehaviour
{
    Rigidbody2D enemy;
    public float speed = 5;

    public SpriteRenderer spriteRenderer;

    public bool walksRight;

    public Transform wallcheck, pitcheck, groundcheck;
    public bool walldetected, pitdetected, isgrounded;
    public float detectionRadius;
    public LayerMask whatIsGround;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        pitdetected = !Physics2D.OverlapCircle(pitcheck.position, detectionRadius, whatIsGround);
        walldetected = Physics2D.OverlapCircle(wallcheck.position, detectionRadius, whatIsGround);

        if (pitdetected || walldetected)
        {
            if (!walksRight)
            {
                walksRight = !walksRight;
                transform.localScale = new Vector3(-2, transform.localScale.y, transform.localScale.z);
            }

            else
            {
                walksRight = !walksRight;
                transform.localScale = new Vector3(2, transform.localScale.y, transform.localScale.z);
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!walksRight)
        {
            enemy.velocity = new Vector2(-speed * Time.deltaTime, enemy.velocity.y);
        }
        else
        {
            enemy.velocity = new Vector2(speed * Time.deltaTime, enemy.velocity.y);
        }
    }
}
