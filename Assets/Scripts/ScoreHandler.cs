using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ScoreHandler : MonoBehaviour, IScoreHandler
{
    public GameObject scoreView;
    
    protected int score = 0;

    protected int maxScore = 5;

    public void OnTriggerEnterItem(GameObject target, Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            score += 1;
            Destroy(target);

            UpdateScore();
            CheckClear();
        }
    }

    public void CheckClear()
    {
        if (score >= maxScore)
        {
            ExecuteEvents.Execute<IGameHandler>(
                gameObject,
                null,
                (handler, data) => handler.Next()
            );
        }
    }

    public void UpdateScore()
    {
        if (!scoreView) return;

        ExecuteEvents.Execute<IScoreViewHandler>(
            scoreView,
            null,
            (handler, data) => handler.SetScore(score)
        );
    }
}
