using System;
using UnityEngine;

public class StateManager : MonoBehaviour
{

    public State[] states;

    public string currentState;
    
    public GameObject canvas;

    private void Start()
    {
        currentState = "Menu State";
    }

    public void SetState(string name, bool overlay)
    {
        Array.Find(states, state => state.name == currentState).state.SetActive(false);
        State s = Array.Find(states, state => state.name == name);
        s.state.SetActive(true);
        currentState = name;

        foreach (GameObject child in s.children)
            child.SetActive(false);

        if (!overlay && s.parent != canvas)
            s.parent.SetActive(false);
    }

}
