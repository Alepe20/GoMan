using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageEnemy : MonoBehaviour
{
    public AudioClip sound = null;
    public float volume = 1;
    protected Transform position = null;

    public void Start()
    {
        position = transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Weapon"))
        {
            Destroy(gameObject);
            ScoreScript.scorevalue += 100;
        }

        if (collision.transform.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sound, position.position, volume);
            collision.transform.GetComponent<RespawnPlayer>().PlayerDamaged();
        }
    }
}
