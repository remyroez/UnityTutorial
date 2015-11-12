using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface IScoreViewHandler : IEventSystemHandler
{
    void SetScore(int score);
}
