using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface IScoreHandler : IEventSystemHandler
{
    void Begin();
    void End();
    void OnTriggerEnterItem(GameObject target, Collider hit);
    void OnCollisionEnterObstacle(GameObject target, Collision hit);
}
