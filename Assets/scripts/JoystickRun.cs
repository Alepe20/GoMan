using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickRun : MonoBehaviour
{
    Rigidbody2D heroe;
    protected Transform position = null;

    private float horizontalMove = 0f;
    public float speedHorizontal = 2;
    public Joystick joystick;

    public float speed = 2;
    public float jumpspeed = 6;
    public float maxspeed = 5;
    public bool grounded;

    private Animator anim;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        heroe = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        position = transform;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        anim.SetBool("grounded", grounded);
        anim.SetFloat("airspeed", heroe.velocity.y);

        if (horizontalMove > 0)
        {
            transform.localScale = new Vector3(2, transform.localScale.y, transform.localScale.z);
        }

        else if (horizontalMove < 0)
        {
            transform.localScale = new Vector3(-2, transform.localScale.y, transform.localScale.z);
        }
    }

    void FixedUpdate()
    {
        horizontalMove = joystick.Horizontal * speedHorizontal;
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * speed;
    }

    public void attack()
    {
        anim.SetTrigger("attack");
    }

    public void jump()
    {
        if (grounded)
            heroe.velocity = new Vector2(heroe.velocity.x, jumpspeed);
    }
}
