using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreViewHandler : MonoBehaviour, IScoreViewHandler
{
    public void SetScore(int score)
    {
        Text text = GetComponent<Text>();
        if (text)
        {
            text.text = score.ToString();
        }
    }
}
