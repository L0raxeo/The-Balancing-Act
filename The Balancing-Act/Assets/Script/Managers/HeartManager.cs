using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartManager : MonoBehaviour
{

    public GameObject[] heart;

    private int lives = 2;

    public void SubtractLife()
    {
        heart[lives].GetComponent<Animator>().SetBool("Destroyed", true);
        Debug.Log(lives);
        lives -= 1;
        CheckDeath();
    }

    public void ResetLives()
    {
        foreach (GameObject o in heart)
            o.SetActive(true);
        lives = 2;
        CheckDeath();
    }

    private void CheckDeath()
    {
        if (lives == 0)
        {
            // game over
        }
    }

}
