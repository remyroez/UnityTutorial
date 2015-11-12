using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PlayStateController : MonoBehaviour
{
    private GameObject _gameController;
    protected GameObject gameController { get { return _gameController ?? (_gameController = GameObject.FindWithTag("GameController")); } }

    void OnEnable()
    {
        if (!gameController) return;

        ExecuteEvents.Execute<IScoreHandler>(
            gameController,
            null,
            (handler, data) => handler.Begin()
        );
    }

    void OnDisable()
    {
        if (!gameController) return;

        ExecuteEvents.Execute<IScoreHandler>(
            gameController,
            null,
            (handler, data) => handler.End()
        );
    }
}
