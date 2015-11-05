using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ScoreHandler : MonoBehaviour, IScoreHandler
{
    public GameObject scoreView;
    
    protected int score = 0;

    public void OnTriggerEnterItem(GameObject target, Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            score += 1;
            Destroy(target);

            UpdateScore();
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
