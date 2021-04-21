using System.Diagnostics;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public StateManager stateManager;

    public Stopwatch stopwatch;
    public GameObject blockPrefab;

    private void Start()
    {
        stopwatch = new Stopwatch();
        StartGame();
    }

    public void StartGame()
    {
        stopwatch.Start();
    }

    public void StopGame()
    {
        stopwatch.Stop();
    }

    private void Update()
    {
        if (stateManager.currentState == "Game State") UpdateGame();
        else if (stateManager.currentState == "Menu State") UpdateMenu();
    }

    private void UpdateMenu()
    {

    }

    private bool blockPlaced = false;

    private void UpdateGame()
    {
        if (stopwatch.Elapsed.Seconds % 4 == 0 && !blockPlaced)
        {
            Instantiate(blockPrefab);
            blockPlaced = true;
        }
        else if (blockPlaced && stopwatch.Elapsed.Seconds % 4 != 0)
        {
            blockPlaced = false;
        }
    }

}
