using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRun : MonoBehaviour
{
    Rigidbody2D heroe;
    protected Transform position = null;

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
        anim.SetFloat("speed", Mathf.Abs(heroe.velocity.x));
        anim.SetBool("grounded", grounded);
        anim.SetFloat("airspeed", heroe.velocity.y);

        if (Input.GetKeyDown("space"))
        {
            anim.SetTrigger("attack");
        }
    }

    void FixedUpdate()
    {

        if (Input.GetKey("right"))
        {
            heroe.velocity = new Vector2(speed, heroe.velocity.y);
            transform.localScale = new Vector3(2, transform.localScale.y, transform.localScale.z);
        }

        else if (Input.GetKey("left"))
        {
            heroe.velocity = new Vector2(-speed, heroe.velocity.y);
            transform.localScale = new Vector3(-2, transform.localScale.y, transform.localScale.z);
        }

        else
        {
            heroe.velocity = new Vector2(0, heroe.velocity.y);
        }

        if (Input.GetKey("up") && grounded)
        {
            heroe.velocity = new Vector2(heroe.velocity.x, jumpspeed);
        }

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
