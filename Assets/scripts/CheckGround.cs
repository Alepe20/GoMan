using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    private JoystickRun hero;

    // Start is called before the first frame update
    void Start()
    {
        hero = GetComponentInParent<JoystickRun>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        hero.grounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        hero.grounded = false;
    }
}
