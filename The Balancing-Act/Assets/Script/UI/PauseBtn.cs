using UnityEngine.UI;
using UnityEngine;

public class PauseBtn : MonoBehaviour
{

    public Image icon;

    public Sprite[] images;
    public GameObject pausedTxt;

    private StateManager stateManager;

    private void Start()
    {
        stateManager = FindObjectOfType<StateManager>();
    }

    public void OnClick()
    {
        switch (Time.timeScale)
        {
            case 0:
                Time.timeScale = 1;
                icon.sprite = images[1];
                stateManager.SetState("Game State", false);
                break;
            case 1:
                Time.timeScale = 0;
                icon.sprite = images[0];
                stateManager.SetState("Pause State", true);
                break;
        }
    }

}
