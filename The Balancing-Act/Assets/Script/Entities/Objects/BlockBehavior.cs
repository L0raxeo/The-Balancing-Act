using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour
{

    private void Start()
    {
        GameObject.FindObjectOfType<ScoreManager>().SetScore(1, true);
    }

    private void Update()
    {
        CheckVoid();
    }

    private void CheckVoid()
    {
        // -10 is the limit
        if (transform.position.y <= -15) Die();
    }

    public void Die()
    {
        Destroy(gameObject);
        if (GameObject.FindObjectOfType<StateManager>().currentState == "Game State")
            GameObject.FindObjectOfType<HeartManager>().SubtractLife();
    }
}
