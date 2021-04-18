using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public TMP_Text score;

    public void SetScore(int score, bool increment)
    {
        if (increment) this.score.text = (int.Parse(this.score.text) + score).ToString();
        else this.score.text = score.ToString();
    }

}
