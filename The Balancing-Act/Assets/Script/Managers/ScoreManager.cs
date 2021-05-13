using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public TMP_Text score;

    public string gamemode;

    public void SetScore(int score, bool increment)
    {
        if (gamemode == "Time Trial")
            return;

        if (increment) this.score.text = (int.Parse(this.score.text) + score).ToString();
        else this.score.text = score.ToString();
    }

    private void Update()
    {
        if (gamemode != "Time Trial")
            return;

        score.text = (System.Math.Round((float) GameObject.FindObjectOfType<LevelManager>().stopwatch.Elapsed.TotalSeconds, 1)).ToString();
    }

    public void ResetScore()
    {
        score.text = "0";
    }

}
