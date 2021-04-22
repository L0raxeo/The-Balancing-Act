using UnityEngine.UI;
using UnityEngine;

public class StatsManager : MonoBehaviour
{

    public Button playBtn;

    private void OnEnable()
    {
        if (GameObject.FindObjectOfType<StateManager>().previousState == "Menu State")
            playBtn.interactable = false;
        else
            playBtn.interactable = true;
    }

}
