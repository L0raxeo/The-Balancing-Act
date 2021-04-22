using System.Diagnostics;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public StateManager stateManager;
    public ScoreManager scoreManager;

    public Stopwatch stopwatch;
    public GameObject blockPrefab;

    private void Start()
    {
        stopwatch = new Stopwatch();
    }

    public void StartGame(string type)
    {
        stopwatch.Start();

        scoreManager.SetScore(0, false);
        GameObject.FindObjectOfType<HeartManager>().ResetLives();
    }

    public void StopGame()
    {
        stopwatch.Stop();

        stateManager.SetState("Stats State", false);
        // check highscore with scoremanager.submiteScore
    }

    private void Update()
    {
        if (stateManager.currentState == "Game State") UpdateGame();
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
