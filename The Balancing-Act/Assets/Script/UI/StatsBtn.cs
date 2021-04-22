using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsBtn : MonoBehaviour
{

    public void OnClick()
    {
        GameObject.FindObjectOfType<StateManager>().SetState("Stats State", false);
    }

}
