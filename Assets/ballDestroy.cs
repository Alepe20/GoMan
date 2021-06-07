using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("cannonball"))
        {
            Destroy(collision.gameObject);
        }

    }
}
