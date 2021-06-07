using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartNewGame : MonoBehaviour
{
    public GameObject transition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        transition.SetActive(true);
        Invoke("charge", 1);
    }

    void charge()
    {
        SceneManager.LoadScene("Level1");
    }
}
