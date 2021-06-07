using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnPlayer : MonoBehaviour
{
    public GameObject transition;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDamaged()
    {
        transition.SetActive(true);
        anim.Play("Personaje_dead");
        Invoke("sceneRestart", 1);
    }

    void sceneRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreScript.scorevalue = 0;
    }
}
