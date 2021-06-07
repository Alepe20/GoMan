using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleted : MonoBehaviour
{
    public GameObject transition;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            transition.SetActive(true);
            ScoreScript.score1 += ScoreScript.scorevalue;
            ScoreScript.scorevalue = 0;
            Invoke("nextLevel", 2);
        }
    }

    void nextLevel()
    {
        SceneManager.LoadScene("Level2");
    }
}
