using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour
{
    public AudioClip sound = null;
    public float volume = 80;
    protected Transform position = null;

    // Start is called before the first frame update
    private void Start()
    {
        position = transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreScript.scorevalue += 300;
            AudioSource.PlayClipAtPoint(sound, position.position, volume);
        }
    }
}