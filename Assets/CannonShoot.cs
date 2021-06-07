using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public float timeToShoot, countdown;

    public GameObject cannonball;

    // Start is called before the first frame update
    void Start()
    {
        countdown = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown < 0)
        {
            shoot();
            countdown = timeToShoot;
        }
    }

    public void shoot()
    {
        GameObject shot = Instantiate(cannonball, transform.position, Quaternion.identity);
        if (transform.localScale.x < 0)
        {
            shot.GetComponent<Rigidbody2D>().AddForce(new Vector2(-100f, 0f), ForceMode2D.Force);
        }
        else
        {
            shot.GetComponent<Rigidbody2D>().AddForce(new Vector2(100f, 0f), ForceMode2D.Force);
        }
    }
}
