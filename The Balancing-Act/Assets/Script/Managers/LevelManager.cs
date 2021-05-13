using System.Diagnostics;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public StateManager stateManager;
    public ScoreManager scoreManager;

    public Stopwatch stopwatch;
    public GameObject blockPrefab;

    public string gamemode;

    private void Start()
    {
        stopwatch = new Stopwatch();
    }

    public void StartGame(string gamemode)
    {
        this.gamemode = gamemode;

        stopwatch.Start();
        scoreManager.gamemode = gamemode;
        scoreManager.ResetScore();
        GameObject.FindObjectOfType<HeartManager>().ResetLives();
    }

    public void StopGame()
    {
        stopwatch.Stop();
        stopwatch.Reset();

        foreach (BoxCollider2D bc in GameObject.FindObjectsOfType<BoxCollider2D>())
        {
            if (bc.gameObject.tag != "Block")
                continue;

            bc.isTrigger = true;
        }

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
