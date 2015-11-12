using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PenaltyObstacleController : MonoBehaviour
{
    private GameObject _gameController;
    protected GameObject gameController { get { return _gameController ?? (_gameController = GameObject.FindWithTag("GameController")); } }

    void OnCollisionEnter(Collision hit)
    {
        if (!gameController) return;
        
        ExecuteEvents.Execute<IScoreHandler>(
            gameController,
            null,
            (handler, data) => handler.OnCollisionEnterObstacle(gameObject, hit)
        );
    }
}
