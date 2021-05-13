using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTrialBtn : MonoBehaviour
{

    public void OnClick()
    {
        GameObject.FindObjectOfType<StateManager>().SetState("Game State", false);
        GameObject.FindObjectOfType<LevelManager>().StartGame("Time Trial");
    }

}
