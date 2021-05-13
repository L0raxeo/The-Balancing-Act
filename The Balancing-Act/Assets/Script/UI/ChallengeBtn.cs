using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeBtn : MonoBehaviour
{

    public void OnClick()
    {
        GameObject.FindObjectOfType<StateManager>().SetState("Game State", false);
        GameObject.FindObjectOfType<LevelManager>().StartGame("Challenge");
    }

}
