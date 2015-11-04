using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ScoreItemController : MonoBehaviour {

    private GameObject _gameController;
    protected GameObject gameController { get { return _gameController ?? (_gameController = GameObject.FindWithTag("GameController")); } }

    void OnTriggerEnter(Collider hit)
    {
        if (!gameController) return;

        ExecuteEvents.Execute<IScoreHandler>(
            gameController,
            null,
            (handler, data) => handler.OnTriggerEnterItem(gameObject, hit)
        );
    }
}
