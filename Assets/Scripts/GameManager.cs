using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public PinSpawner pinSpawner;

    public Animator animator;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
    }

    public void EndGame()
    { 
        if (gameHasEnded)
        {
            return;
        }

        rotator.enabled = false;
        pinSpawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
    }

    public void RestartLevel()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }
}
       