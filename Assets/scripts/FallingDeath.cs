using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDeath : MonoBehaviour
{
    public AudioClip sound = null;
    public float volume = 1;
    protected Transform position = null;

    public void Start()
    {
        position = transform;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sound, position.position, volume);
            collision.transform.GetComponent<RespawnPlayer>().PlayerDamaged();
        }

    }
}
