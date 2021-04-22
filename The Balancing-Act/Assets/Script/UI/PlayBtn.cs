using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBtn : MonoBehaviour
{

    public StateManager stateManager;

    public void OnClick()
    {
        stateManager.SetState(stateManager.previousState, false);
        GameObject.FindObjectOfType<LevelManager>().StartGame(""); // type of game goes in ""
    }

}
